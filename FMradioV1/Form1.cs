/*
Data: decembrie 2016
Author: Florin Nica
- GUI pt. radio FM RDA 5807
- se foloseste un adaptor USB-serial FTDI, eventual cu eepromul modificat(CTS, RTS, DTR inversate cu programul MPROG/FT_Prog)

 RTS ------ SCL
 DTR ------ SDA

 Surse de inspiratie:
 * Complete practical measurement systems using a PC - Yury Magda (modul de emulare a protocolului I2C prin portul serial)
 * https://forum.arduino.cc/index.php?topic=221368.0 (un exemplu foarte simplu de testare pe Arduino a modulului)
 * datasheet RDA 5807M


*/


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
using System.Threading;

namespace FMradioV1
{

    public partial class radioFmForm : Form
    {
        
        SerialPortClass ComPort = new SerialPortClass();

        int freq;
        


        public radioFmForm()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            updatePorts();
            trackBar1.SetRange(870, 1080);
            trackBar1.Value = 870;
            volTrackBar.SetRange(0, 15);
            volTrackBar.Value = 15;
            volTrackBar.TickFrequency = 3;
            trackBar1.TickFrequency = 10;
            freqTextBox.Text = "87.0 MHz";
            stationLabel.Visible = false;

        }

        public void updatePorts()    //lista porturilor disponibile
        {
            foreach (string port in ComPort.update())
            {
                portNameComboBox.Items.Add(port);
            }

            // default settings
            try
            {
                portNameComboBox.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("No Serial Port", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Object port = portNameComboBox.SelectedItem;
                portLabel.Text = " No port";

            }

        }
        public void connect()
        {
            bool error = false;
            //verifica daca toate setarile au fost selectate
            if (portNameComboBox.SelectedIndex != -1)
            {
                //Object port = portNameComboBox.SelectedItem;
                ComPort.portName = portNameComboBox.Text;
              

                try  // allways try to use this try and catch method to open your port
                // if there is an error your program will not display a message instead of freezing
                {
                    // open Port
                    ComPort.openPort();
                    
                    portLabel.Text = ComPort.portName + " connected";

                    //making Clock and SDA line stable
                   //ComPort.sclLow();
                   //ComPort.sdaLow();

                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (System.IO.IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error)
                {
                    MessageBox.Show(this, "Nu pot deschide portul COM. Probabil este deja in folosinta, a fost indepartat sau nu este disponibil",
                    "Portul COM nu este disponibil", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();  //inchide aplicatia daca nu mai exista port
                }

            }
            else  //daca nu,....
            {
                MessageBox.Show("Selectati portul", "Interfață port serial", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            // daca portul e deschis, schimba textul butonului Conectare in Deconectare          
            if (ComPort.isOpen)
            {
                connectButton.Text = "Disconnect";
                connectButton.BackColor = Color.CadetBlue;

            }

        } //end connect
        public void disconnect()
        {
            ComPort.closePort();
            connectButton.BackColor = Color.DarkGray;
            connectButton.Text = "Connect";
        }
        public void connectButton_Click(object sender, EventArgs e)
        {
            if (ComPort.isOpen)
            {
                disconnect();
                Object port = portNameComboBox.SelectedItem;
                portLabel.Text = port + " disconnected";
            }
            else
            {
                connect();
            }
        }

        public void muteButton_Click(object sender, EventArgs e)
        {
            
        }
        private void powerOnButton_Click(object sender, EventArgs e)
        {
          
        }


        #region I2C
        public void noAck() // Waits for NACK from master
        {
            ComPort.sclLow();
            ComPort.sdaHigh();
            ComPort.sclHigh();
        }
        public void waitAck() // Waits for ACK bit from device
        {
            ComPort.sclLow();
            ComPort.sdaHigh();
            ComPort.sclHigh();
        }
        public void startI2C()
        {
            //ComPort.sclLow();
            ComPort.sdaHigh();
            ComPort.sclHigh();
            ComPort.sdaLow();
        }
        public void stopI2C()
        {
            ComPort.sclLow();
            ComPort.sdaLow();
            ComPort.sclHigh();
            ComPort.sdaHigh();
        }
        public void restartI2C()
        {
            ComPort.sclLow();
            ComPort.sdaHigh();
            ComPort.sclHigh();
            ComPort.sdaLow();
        }

        public void write(byte c1)   // Writing a byte to the device
        {
            byte b = 0x80;
            byte tmp = 0x0;
            for (int k = 0; k < 8; k++)
            {
                ComPort.sclLow();
                tmp = (byte)(c1 & b);
                if (tmp != 0)
                    ComPort.sdaHigh();
                else
                    ComPort.sdaLow();
                ComPort.sclHigh();
                b = (byte)(b >> 1);
            }
        }

        public byte read()
        {
            byte c1 = 0;
            byte b = 0x80;
            ComPort.sclLow();
            ComPort.sdaHigh();
            for (int j = 0; j < 8; j++)
            {
                ComPort.sclLow();
                if (ComPort.isSdaHigh)   // if (ComPort.CtsHolding == false), check if SDA = 1
                    c1 |= b;
                ComPort.sclHigh();
                b = (byte)(b >> 1);

            }
            return c1;
        }

        #endregion I2C

        public void setVolume(byte v)
        {
            startI2C();
            write(0x22);
            waitAck();
            write(0x05); // volume register
            waitAck();
            write(0x88); // nu ne intereseaza
            waitAck();
            write(v); // only first 4 bits for volume
            waitAck();
            stopI2C();
        }
        private void startRadioButton_Click(object sender, EventArgs e)
        {
            freq = trackBar1.Value;
            //freq = 887;
            byte freqB = (byte)(freq - 870);
            byte freqH = (byte)(freqB >> 2);
            byte freqL = (byte)((freqB & 3) << 6);

            startI2C();
            write(0x22);  // adresa 0x11 plus bitul de scriere -> 00010001 + 0(bit scriere)-> 00100010 (0x22)
            waitAck();
            write(0x02);
            waitAck();
            write(0xC0);
            //write(0xD0); // bass boost
            waitAck();
            write(0x03);
            waitAck();
            stopI2C();

            //Thread.Sleep(350);

            startI2C();
            write(0x22);
            waitAck();
            write(0x02);
            waitAck();
            //write(0xC0);
            write(0xD0); // bass boost
            waitAck();
            write(0x0D);
            waitAck();
            stopI2C();
 
            //Thread.Sleep(350);

            startI2C();
            write(0x22);
            waitAck();
            write(0x03);
            waitAck();
            write(freqH);
            waitAck();
            write((byte)(freqL + 0x10));
            waitAck();
            stopI2C();
            stationLabel.Visible = true;

        }

        private void freqUpButton_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 1080) trackBar1.Value++;
            freq = trackBar1.Value;
            int f1 = freq / 10;
            int f2 = freq % 10;
            freqTextBox.Text = f1.ToString() + "." + f2.ToString() + " MHz";
            tuneButton.Visible = true;
            stationLabel.Visible = false;

        }

        private void freqDownButton_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > 870) trackBar1.Value--;
            freq = trackBar1.Value;
            int f1 = freq / 10;
            int f2 = freq % 10;
            freqTextBox.Text = f1.ToString() + "." + f2.ToString() + " MHz";
            tuneButton.Visible = true;
            stationLabel.Visible = false;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            freq = trackBar1.Value;
            int f1 = freq / 10;
            int f2 = freq % 10;
            freqTextBox.Text = f1.ToString() + "." + f2.ToString() + " MHz";
            tuneButton.Visible = true;
            stationLabel.Visible = false;
        }

        private void freqTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tuneButton_Click(object sender, EventArgs e)
        {
            freq = trackBar1.Value;
            byte freqB = (byte)(freq - 870);
            byte freqH = (byte)(freqB >> 2);
            byte freqL = (byte)((freqB & 3) << 6);
            startI2C();
            write(0x22);
            waitAck();
            write(0x03);
            waitAck();
            write(freqH);
            waitAck();
            write((byte)(freqL + 0x10));
            waitAck();
            stopI2C();
            tuneButton.Hide();
            stationLabel.Visible = true;
        }

        private void volTrackBar_Scroll(object sender, EventArgs e)
        {
            int volum = volTrackBar.Value;
            switch (volum)
            {
                case 0:
                    setVolume(0xC0);
                    break;
                case 1:
                    setVolume(0xC1);
                    break;
                case 2:
                    setVolume(0xC2);
                    break;
                case 3:
                    setVolume(0xC3);
                    break;
                case 4:
                    setVolume(0xC4);
                    break;
                case 5:
                    setVolume(0xC5);
                    break;
                case 6:
                    setVolume(0xC6);
                    break;
                case 7:
                    setVolume(0xC7);
                    break;
                case 8:
                    setVolume(0xC8);
                    break;
                case 9:
                    setVolume(0xC9);
                    break;
                case 10:
                    setVolume(0xCA);
                    break;
                case 11:
                    setVolume(0xCB);
                    break;
                case 12:
                    setVolume(0xCC);
                    break;
                case 13:
                    setVolume(0xCD);
                    break;
                case 14:
                    setVolume(0xCE);
                    break;
                case 15:
                    setVolume(0xCF);
                    break;

            }

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startI2C();
            write(0x22);
            waitAck();
            write(0x02);
            waitAck();
            write(0x90);
            waitAck();
            write(0x00);
            waitAck();
            stopI2C();
            stationLabel.Visible = false;
        }
    }
}
