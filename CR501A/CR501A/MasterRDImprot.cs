using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CR501A
{
    class MasterRDImprot
    {
        /// <tóm tắt>
                 /// Mở cổng nối tiếp
                 /// </ summary>
                 /// <param name = "port"> Số sê-ri </ param>
                 /// <param name = "baud"> baud rate </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_init_com")]
        internal static extern int rf_init_com(ushort port, ushort baud);

        /// <tóm tắt>
                 /// Đóng cổng nối tiếp mở
                 /// </ summary>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_ClosePort")]
        internal static extern int rf_ClosePort();

        /// <tóm tắt>
                 /// đọc số sêri, thẻ được chỉ định
                 /// </ summary>
                 /// <param name = "icdev"> số thiết bị, mặc định 0 </ param>
                 /// <param name = "pData"> Chấp nhận dữ liệu đã trả về </ param>
                 /// <param name = "retLen"> Trả về chiều dài dữ liệu nhận được </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_s70_select")]
        internal static extern int rf_s70_select(byte icdev, byte[] pData, ref byte retLen);

        /// <tóm tắt>
                 /// Đọc nội dung của khối xác định bằng cách sử dụng khoá được chỉ định
                 /// </ summary>
                 /// <param name = "icdev"> số thiết bị, mặc định 0 </ param>
                 /// <param name = "ReadMode"> chế độ đọc, 0: đọc 0-31 khối, 1: đọc 32-38 khối, 2: đọc 2 khối </ param>
                 /// <param name = "address"> Đọc địa chỉ khối (giá trị s70 1-32) </ param>
                 /// <param name = "KeyMode"> Chế độ khóa, phím A = 0x60, phím B = 0x61 </ param>
                 /// <param name = "Key"> phím 6 byte </ param>
                 /// <param name = "pData"> Trả lại nội dung của khối đọc </ param>
                 /// <param name = "retLen"> Trả về độ dài của nội dung của khối đọc </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_s70_read")]
        internal static extern int rf_s70_read(byte icdev, byte ReadMode, byte address, byte KeyMode, byte[] Key, byte[] pData, ref ulong retLen);
        
        /// <tóm tắt>
                 /// Ghi nội dung được chỉ định bằng cách sử dụng khoá được chỉ định
                 /// </ summary>
                 /// <param name = "icdev"> số thiết bị: mặc định 0 </ param>
                 /// <param name = "WriteMode"> chế độ đọc, 0: đọc 0-31 khối, 1: đọc 32-38 khối, 2: đọc 2 khối (tất cả) </ param>
                 /// <param name = "address"> Đọc địa chỉ khối (giá trị s70 1-32) </ param>
                 /// <param name = "KeyMode"> Chế độ khóa, phím A = 0x60, phím B = 0x61 </ param>
                 /// <param name = "Key"> phím 6 byte </ param>
                 /// <param name = "pData"> Những gì để viết (1 khối 16 byte) </ param>
                 /// <param name = "retLen"> chiều dài của nội dung bằng văn bản </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_s70_write")]
        internal static extern int rf_s70_write(byte icdev, byte WriteMode, byte address, byte KeyMode, byte[] Key, byte[] pData, ulong retLen);

        /// <tóm tắt>
                 /// Ghi nhóm chính vào người đọc
                 /// </ summary>
                 /// <param name = "icdev"> số thiết bị </ param>
                 /// <param name = "block"> Số nhóm chỉ số chính (giá trị 0-31) </ param>
                 /// <param name = "Key"> Dữ liệu chính (6 byte) </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_M1_WriteKeyToEE2")]
        internal static extern int rf_M1_WriteKeyToEE2(byte icdev, byte block, byte[] Key);

        /// <tóm tắt>
                 /// Kiểm tra khóa trên khối đã chỉ định
                 /// </ summary>
                 /// <param name = "icdev"> số thiết bị, mặc định 0 </ param>
                 /// <param name = "KeyMode"> chế độ khóa, phím A = 0x60, phím B = 0x61 </ param>
                 /// <param name = "block"> Chỉ định khối </ param>
                 /// <param name = "secnr"> Số khóa (chỉ số nhóm chính 0-31) </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_M1_authentication1")]
        internal static extern int rf_M1_authentication1(byte icdev, byte KeyMode, byte block, byte secnr);

        /// <tóm tắt>
                 /// Đọc thẻ bằng cách sử dụng phương pháp nhóm chính. Trước khi thực hiện thao tác này, bạn phải kiểm tra khóa
                 /// </ summary>
                 /// <param name = "icdev"> số thiết bị </ param>
                 /// <param name = "block"> khối số </ param>
                 /// <param name = "pData"> Trả lại những gì đã được đọc </ param>
                 /// <param name = "pLen"> trả về độ dài của read (in bytes) </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_M1_read")]
        internal static extern int rf_M1_read(byte icdev, byte block, byte[] pData, ref ulong pLen);

        /// <tóm tắt>
                 /// ghi dữ liệu bằng cách sử dụng chế độ nhóm mật khẩu, thực hiện một hoạt động phụ phải được thực hiện trước khi hoạt động kiểm tra chìa khóa
                 /// </ summary>
                 /// <param name = "icdev"> số thiết bị </ param>
                 /// <param name = "block"> khối số </ param>
                 /// <param name = "pData"> Dữ liệu viết (16 byte) </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_M1_write")]
        internal static extern int rf_M1_write(byte icdev, byte block, byte[] pData);

        /// <tóm tắt>
                 /// Đọc số thẻ M1,
                 /// </ summary>
                 /// <param name = "icdev"> thiết bị mặc định 0 </ param>
                 /// <param name = "pData"> Dữ liệu số nối tiếp đã được trả lại </ param>
                 /// <param name = "pLen"> chiều dài dữ liệu </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_select1")]
        internal static extern int rf_select1(byte icdev, byte[] pData, ref ulong pLen);

        /// <tóm tắt>
                 /// kiểm tra thẻ M1
                 /// </ summary>
                 /// <param name = "icdev"> số thiết bị, mặc định 0 </ param>
                 /// <param name = "KeyMode"> chế độ khóa, phím A = 0x60, phím B = 0x61 </ param>
                 /// <param name = "block"> khối số </ param>
                 /// <param name = "key"> byte chính </ param>
                 /// <returns> trở lại 0 </ returns> thành công
        [DllImport("MasterRD.dll", EntryPoint = "rf_M1_authentication2")]
        internal static extern int rf_M1_authentication2(byte icdev, byte KeyMode, byte block, byte[] key);

        // <tóm tắt>
        /// Mở đèn LED được chỉ định
                 /// </ summary>
                 /// <param name = "icdev"> </ param>
                 /// <param name = "color"> 0: Tất cả đèn bật, 1: Đèn đỏ, 2: Đèn xanh, 3: Tất cả đèn sáng </ param>
                 /// <returns> </ returns>
        [DllImport("MasterRD.dll", EntryPoint = "rf_light")]
        internal static extern int rf_light(byte icdev, byte color);

        [DllImport("MasterRD.dll", EntryPoint = "rf_beep")]
        internal static extern int rf_beep(byte icdev, int msec);
    }

    

}
