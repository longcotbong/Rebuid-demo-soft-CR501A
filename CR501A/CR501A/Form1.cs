using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CR501A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Reader_S70 reader_S70 = new Reader_S70();
        ushort baud = 19200;



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] comNos = SerialPort.GetPortNames();
            cbCom.Items.Clear();
            for (int i = 0; i < comNos.Length; i++)
            {
                cbCom.Items.Add(comNos[i]);
            }
            
            
        }

        private void btCom_Click(object sender, EventArgs e)
        {
            if (btCom.Text == "Open") {
                ushort comNo = Convert.ToUInt16(cbCom.Text.Substring(3));
                if (reader_S70.OpenCom(comNo, baud))
                {
                    btCom.Text = "Close";
                }
            }

            else
            {
                if (reader_S70.CloseCom())
                {
                    btCom.Text = "Open";
                }
            }
        }

        private void btBeep_Click(object sender, EventArgs e)
        {
            reader_S70.Beep(10);
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            reader_S70.OpenLed(LightColor.CloseLED);
        }

        private void btLedY_Click(object sender, EventArgs e)
        {
            reader_S70.OpenLed(LightColor.GreenLED);
        }
        private void btOn_Click(object sender, EventArgs e)
        {
            reader_S70.OpenLed(LightColor.AllLED);
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            byte[] blockData = null;
            string blockDatastr = null;
            string cardSerialNo = string.Empty;
            byte[] cxh;
            bool readOK = false;

            blockData = reader_S70.ReadData(KeyModeEnum.KeyA, 0, "FFFFFFFFFFFF", out cxh);
            if (blockData != null)
            {
                blockDatastr = reader_S70.GetStringByData(blockData);
                cardSerialNo = reader_S70.GetStringByData(cxh);
                readOK = true;
            }
            if (readOK)
            {
                tbName.Text = blockDatastr;
                tbContent.Text = cardSerialNo;
            }
        }
    }
}
