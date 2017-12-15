using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace FMradioV1
{
    public class SerialPortClass
    {
       SerialPort _serialPort = new SerialPort();

        public SerialPortClass()
        {
            _serialPort.PortName = " ";
            _serialPort.BaudRate = 9600;   //9600
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
           
        }
        public bool isSdaHigh
        {
            get
            {
                return (!_serialPort.CtsHolding);
            }
        }
        public bool isOpen
        {
            get
            {
                return _serialPort.IsOpen;
            }
        }
        public string portName
        {
            get
            {
                return _serialPort.PortName;
            }
            set
            {
                _serialPort.PortName = value;
            }
        }

        public string[] update()    //lista porturilor disponibile
        {
            string[] porturi = SerialPort.GetPortNames();
            return porturi;
        }

        public void openPort()
        {
            _serialPort.Open();
        }

        public void closePort()
        {
            _serialPort.Close();
        }

        public void reset()
        {
            _serialPort.Write("\0");
        }
        public void sclLow()
        {
            _serialPort.RtsEnable = true;
        }
        public void sclHigh()
        {
            _serialPort.RtsEnable = false;
        }


        public void sdaLow()
        {
            _serialPort.DtrEnable = true;
        }
        public void sdaHigh()
        {
            _serialPort.DtrEnable = false;
        }


    }
}
