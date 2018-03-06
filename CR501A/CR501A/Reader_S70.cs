using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR501A
{
    public enum ReadWriteTypeModeEnum
    {
        Read0To31 = 0,
        Read32TO38 = 1,
        ReadAll = 2
    }
    /// <summary>
    /// Chon phim a ,chon phim b
    /// </summary>
    public enum KeyModeEnum
    {
        KeyA = 0x60,
        KeyB = 0x61
    }
    /// <summary>
    /// Loai khoa: nhom mat khau hoac mat khua goc
    /// </summary>
    public enum UseKeyModeEnum
    {
        Key = 0,
        KeyGroup = 1
    }

    /// <summary>
    /// Mau led
    /// </summary>
    public enum LightColor
    {
        /// <summary>
        /// Tat led
        /// </summary>
        CloseLED = 0x00,
        /// <summary>
        /// do
        /// </summary>
        RedLED = 0x01,
        /// <summary>
        /// xanh
        /// </summary>
        GreenLED = 0x02,
        /// <summary>
        /// sang het led
        /// </summary>
        AllLED = 0x03
    }
    class Reader_S70
    {
        public byte[] GetWriteData(string dataStr)
        {
            if (dataStr.Length % 2 != 0)
            {
                throw new Exception("GetBlockData,Chieu dai khong xac dinh");
            }
            try
            {
                List<byte> rList = new List<byte>();
                for (int i = 0; i < dataStr.Length; i += 2)
                {
                    byte d = Convert.ToByte(dataStr.Substring(i, 2), 16);
                    rList.Add(d);
                }
                return rList.ToArray();
            }
            catch
            {
                throw new Exception("GetBlockData,chuyen doi du lieu that bai,dataStr phai la he thap luc phan");
            }

        }

        // Lay chia khoa
        public byte[] GetKeyData(string keyStr)
        {
            byte[] r = GetWriteData(keyStr);
            if (r.Length != 6)
            {
                throw new Exception("Do dai mat khau khong chinh xac!");
            }
            return r;
        }

        //Thu được bằng số byte chuỗi khối, chiều dài không bằng 16 kích hoạt một trường
        public byte[] GetBlockData(string blockStr)
        {
            byte[] r = GetWriteData(blockStr);
            if (r.Length != 16)
            {
                throw new Exception("写入数据长度不正确");
            }
            return r;
        }

        //Chuyen byte[] sang chuoi
        public string GetStringByData(byte[] data)
        {
            if (data == null) return null;
            StringBuilder sbText = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sbText.Append(data[i].ToString("X2"));
            }
            return sbText.ToString();
        }

        public bool OpenCom(ushort comNo, ushort baud)
        {
            try
            {
                int r = MasterRDImprot.rf_init_com(comNo, baud);
                return r == 0 ? true : false;
            }
            catch
            {
                throw new Exception("调用 rf_init_com 函数失败!");
            }
        }

        public bool CloseCom()
        {
            try
            {
                int r = MasterRDImprot.rf_ClosePort();
                return r == 0 ? true : false;
            }
            catch
            {
                throw new Exception("调用 rf_ClosePort 函数失败!");
            }
        }

        public byte[] SelectCard()
        {
            byte[] pData = new byte[10];
            byte pdataLen = 0;
            int r = MasterRDImprot.rf_s70_select(0, pData, ref pdataLen);
            if (r == 0)
            {
                byte[] rData = new byte[pdataLen];
                for (int i = 0; i < pdataLen; i++)
                {
                    rData[i] = pData[i];
                }
                return rData;
            }
            return null;
        }

        //Lấy chìa khóa để đọc thẻ
        public bool DownloadKeyToReader(byte blockNo, string keystr)
        {
            byte[] key = GetKeyData(keystr);
            int r = MasterRDImprot.rf_M1_WriteKeyToEE2(0, blockNo, key);
            if (r == 0)
            {
                return true;
            }
            return false;
        }

        //Kiểm tra khóa của nhóm chính trong trình đọc thẻ
        public bool CheckReaderKey(byte keyModel, byte blockNo, byte keyGroupIndex)
        {
            int r = MasterRDImprot.rf_M1_authentication1(0, keyModel, blockNo, keyGroupIndex);
            return r == 0 ? true : false;
        }

        public byte[] ReadData(KeyModeEnum km, byte blokNo, string keyStr, out byte[] cardSerialData)
        {
            // byte readModel = (byte)rm;
            byte keyModel = (byte)km;
            byte[] key = GetKeyData(keyStr);
            byte[] pData = new byte[100];
            ulong pdataLen = 0;
            // đọc số thẻ
            cardSerialData = SelectCard();
            if (cardSerialData == null) return null;
            int r;
            // Kiểm tra chìa khóa
            r = MasterRDImprot.rf_M1_authentication2(0, keyModel, blokNo, key);

            r = MasterRDImprot.rf_M1_read(0, blokNo, pData, ref pdataLen);
            if (r == 0)
            {
                byte[] rData = new byte[pdataLen];
                for (int i = 0; i < (int)pdataLen; i++)
                {
                    rData[i] = pData[i];
                }
                return rData;
            }
            return null;
        }

        public byte[] ReadData(ReadWriteTypeModeEnum rm, KeyModeEnum km, byte blockNo, byte keyGroupIndex, out byte[] cardSerialData)
        {
            //byte readModel = (byte)rm;
            byte keyModel = (byte)km;
            cardSerialData = SelectCard();
            if (cardSerialData == null) return null;
            if (CheckReaderKey(keyModel, blockNo, keyGroupIndex))
            {
                byte[] pData = new byte[100];
                ulong pDataLen = 0;
                int r = MasterRDImprot.rf_M1_read(0, blockNo, pData, ref pDataLen);
                if (r == 0)
                {
                    byte[] resultData = new byte[pDataLen];
                    for (int i = 0; i < (int)pDataLen; i++)
                    {
                        resultData[i] = pData[i];
                    }
                    return resultData;
                }
            }
            return null;
        }

        public bool WriteData(KeyModeEnum km, byte blockNo, string keyStr, string pDataStr)
        {
            //byte readModel = (byte)rm;
            byte keyModel = (byte)km;
            byte[] key = GetKeyData(keyStr);
            byte[] pData = GetBlockData(pDataStr);
            ulong pLen = (ulong)pData.Length;
            SelectCard();
            int r;
            //kiem tra chia khoa
            r = MasterRDImprot.rf_M1_authentication2(0, keyModel, blockNo, key);

            r = MasterRDImprot.rf_M1_write(0, blockNo, pData);
            return r == 0 ? true : false;
        }

        public bool WriteData(ReadWriteTypeModeEnum rm, KeyModeEnum km, byte blockNo, byte keyGroupIndex, string pDataStr)
        {
            byte readModel = (byte)rm;
            byte keyModel = (byte)km;
            SelectCard();
            if (CheckReaderKey(keyModel, blockNo, keyGroupIndex))
            {
                byte[] pData = GetWriteData(pDataStr);
                int r = MasterRDImprot.rf_M1_write(0, blockNo, pData);
                return r == 0 ? true : false;
            }
            return false;
        }


        public bool OpenLed(LightColor lc)
        {
            byte color = (byte)lc;
            int r = MasterRDImprot.rf_light(0, color);
            return r == 0 ? true : false;
        }
        public bool Beep(int msec)
        {
            int r = MasterRDImprot.rf_beep(0, msec);
            return r == 0 ? true : false;
        }
    }
}
