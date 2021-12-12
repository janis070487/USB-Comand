// Comand_Style+code
using MaterialSkin;
using MaterialSkin.Controls;
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

namespace USB_Comand
{
    public partial class Form1 : MaterialForm
    {
        bool isConnected = false;
        bool comandend = true;
        String[] ComandEndValue = new string[] { "None", "NL" };
        String[] ports;
        SerialPort port;
        int[] botSpeed = new int[] {
        300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 74880, 115200, 230400, 250000, 500000, 1000000, 2000000
        };
        int[] BuferSizeRead = new int[]
        {
            1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608
        };
        int[] BuferSizeWrite = new int[]
        {
            1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608
        };
        string RealDataSpeed = "9600";     // Datu ātrums pēc noklusējuma
        string RealComandEnd = "NL";    // Comandas ātrums pēc noklusējuma
        string RealreadBuferSize = "4096"; // Datu saņemšanas bufera izmērs pēc noklusējuma
        string RealwriteBuferSize = "2048";// Datu nosūtīšanas bufera izmēra pēc noklusējuma
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // disableControls();
            Init();
            getAvailableComPorts(); // Iegūst us šī dator
                //Console.WriteLine(port);
             
            if(ports.Length == 0)   // Ja neatrod nevienu ierīci tad pogu conect padara neaktīvu
            {
                ConectDisconect.Enabled = false;
            }
            foreach (string port in ports) // cikls pievieno izvele com usb pievienojumus
            {
                ComPort.Items.Add(port);
                if (ports[0] != null)
                {
                    ComPort.SelectedItem = ports[0]; //a pievienotus usb portus
                }
            }
            for(int a = 0; a < ComandEndValue.Length; a++)
            {
                ComandEnd.Items.Add(ComandEndValue[a]);
            }
            for(int i = 0; i < botSpeed.Length; i++)
            {
                DataSpeed.Items.Add(botSpeed[i]);
            }
            for(int j = 0; j < BuferSizeRead.Length; j++)
            {
                ReadBuferSize.Items.Add(BuferSizeRead[j]);
            }
            for(int k = 0; k < BuferSizeWrite.Length; k++)
            {
                WriteBuferSize.Items.Add(BuferSizeWrite[k]);
            }
        }
                         // Izveles

        //_______________________________________________________________________________
        private void ComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComPort.SelectedItem = ComPort.SelectedItem;
        }

        private void DataSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealDataSpeed = DataSpeed.GetItemText(DataSpeed.SelectedItem);
            DataSpeedName.Text = "Data speed - Set now = " + RealDataSpeed + " bot / sec";
        }

        private void ComandEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(ComandEnd.Ge)
            RealComandEnd = ComandEnd.GetItemText(ComandEnd.SelectedItem);
            ComandEndText.Text = "Comand end - Set now = " + RealComandEnd;
        }

        private void ReadBuferSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealreadBuferSize = ReadBuferSize.GetItemText(ReadBuferSize.SelectedItem);
            ReadBuferSizeText.Text = "Read data bufer size - Set now = " + Convert.ToInt32(RealreadBuferSize) / 1024 + " KB";
        }

        private void WriteBuferSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealwriteBuferSize = WriteBuferSize.GetItemText(WriteBuferSize.SelectedItem);
            WriteBuferSizeText.Text = "Write data bufer size - Set now = " + Convert.ToInt32(RealwriteBuferSize) / 1024 + " KB";
        }
        //_______________________________________________________________________________

        private void disableControls()
        {
           //ConectDisconect.Enabled = false;
        }
        void getAvailableComPorts()  // Iegūst un ieraksta masīvā pieejamos com portus esošajam datoram
        {
           
            ports = SerialPort.GetPortNames();
        }

        private void ConectDisconect_Click(object sender, EventArgs e)   // reaģē uz pogas spiešanu kas atvieno vai pievieno comportam izvēlēto ierīci
        {
            if (!isConnected)
            {
                Connect();
            }
            else
            {
                Disconnect();
            }
        }
        //             nospiežot izvadās uzraksts par to ko nozīmē šis uzraksts
        //____________________________________________________________
        private void DataSpeedName_Click(object sender, EventArgs e)
        {

        }
        
        private void ComandEndText_Click(object sender, EventArgs e)
        {

        }

        private void ReadBuferSizeText_Click(object sender, EventArgs e)
        {

        }

        private void WriteBuferSizeText_Click(object sender, EventArgs e)
        {

        }

        private void ComPortName_Click(object sender, EventArgs e)
        {

        }
        //____________________________________________________________________
        private void Connect()    
        {
            
            isConnected = true;
            string selectedPort = ComPort.GetItemText(ComPort.SelectedItem);
            port = new SerialPort(selectedPort, Convert.ToInt32(RealDataSpeed), Parity.None, 8, StopBits.One);
            port.ReadBufferSize = Convert.ToInt32(RealreadBuferSize);
            port.WriteBufferSize = Convert.ToInt32(RealwriteBuferSize);
            port.Open();
            ConectDisconect.Text = "Disconnect";
            enableControls();
        }
        private void Disconnect()
        {
            isConnected = false;
            port.Close();
            ConectDisconect.Text = "Connect";
            disableControls();
            resetDefaults();
        }
        private void Init()
        {
            DataSpeedName.Text = "Data speed - Set now = " + RealDataSpeed + " boti / sec";
            ComandEndText.Text = "Comand end - Set now = NL";
            ReadBuferSizeText.Text = "Read bufer size - Set now = " + Convert.ToInt32(RealreadBuferSize) / 1024 + " KB" ;
            WriteBuferSizeText.Text = "Write bufer size - Set now = " + Convert.ToInt32(RealwriteBuferSize) / 1024 + " KB"; 


        }
        private void enableControls()
        {
            ComPort.Enabled = false;
            DataSpeed.Enabled = false;
            ComandEnd.Enabled = false;
           ReadBuferSize.Enabled = false;
           WriteBuferSize.Enabled = false;
            RefreshName.Enabled = false;
        }
        private void resetDefaults()
        {
            ComPort.Enabled = true;
            DataSpeed.Enabled = true;
            ComandEnd.Enabled = true;
            ReadBuferSize.Enabled = true;
            WriteBuferSize.Enabled = true;
            RefreshName.Enabled = true;
        }

        private void RefreshName_Click(object sender, EventArgs e) // Atjauno sarakstu ar comportiem ja bij pievienota vēl kāda ierīce
        {
            ComPort.Items.Clear();
            getAvailableComPorts();
            // ports = SerialPort.GetPortNames();
            if (ports.Length == 0)   // Ja neatrod nevienu ierīci tad pogu conect padara neaktīvu
            {
                ConectDisconect.Enabled = false;
            }
            else
            {
                ConectDisconect.Enabled = true;
            }

            foreach (string port in ports) // cikls pievieno izvele com usb pievienojumus
            {
                ComPort.Items.Add(port);
                if (ports[0] != null)
                {
                    ComPort.SelectedItem = ports[0]; //a pievienotus usb portus
                }
            }

        }
        //         Objekti ComPortam
        //________________________________________________________________________
        private void SendButon_Click(object sender, EventArgs e)
        {
           
            
                //hh.Text = "janis - " + i;
                //WR.Text = "janis - " + i;
                //tt.Text = tt.Text + "Janis - " + i + '\n';
                WriteComandText.Text = WriteComandText.Text + SendComand.Text + '\n';
            SendComand.Text = "";
            
        }

        private void AddToListButon_Click(object sender, EventArgs e)
        {

        }

        private void restartButon_Click(object sender, EventArgs e)
        {

        }

        private void ModeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimeStampCexBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LineNumberCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

        }

        private void PauseButton_Click(object sender, EventArgs e)
        {

        }
        //_____________________________________________________________________
    }
}
