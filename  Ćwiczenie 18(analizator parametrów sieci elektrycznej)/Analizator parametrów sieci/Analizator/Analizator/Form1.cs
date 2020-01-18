using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizator
{
    public partial class MainForm : Form
    {

        private const string endPointIpv4Address = "169.254.2.10";
        private const int endPointTCPPort = 502;
        private TcpClient tcpClient;
        private NetworkStream networkStream;

        public MainForm()
        {
            InitializeComponent();
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(IPAddress.Parse(endPointIpv4Address), endPointTCPPort);
                networkStream = tcpClient.GetStream();
                timerUpdate.Start();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            textBoxVoltage.Text = getVoltageL1();
            textBoxCurrent.Text = getCurrentL1();
            textBoxCosinus.Text = getCosPhi();
            textBoxActivePower.Text = getActivePowerL1();
            textBoxFrequency.Text = getFrequencyL1();
        }

        string getVoltageL1()
        {
            byte[] request =
            {
                //nr zapytania 2B
                0x00, 0x01,
                //protokol modbus
                0x00, 0x00,
                //dlugosc danych
                0x00, 0x06,
                //nr urzadzenia
                0x01,
                //funkcja read
                0x03,
                //addres rejestru
                0x10, 0x02,
                //liczba rejestrow
                0x00, 0x02
            };
            networkStream.Write(request, 0, request.Length);

            byte[] response = new byte[15];
            networkStream.Read(response, 0, response.Length);
            Console.WriteLine("Napiecie:\n" + BitConverter.ToString(response));

            byte[] voltageL1Hex = new byte[4];
            Array.ConstrainedCopy(response, 9, voltageL1Hex, 0, voltageL1Hex.Length);
            Array.Reverse(voltageL1Hex);
            return (BitConverter.ToUInt32(voltageL1Hex, 0) / 1000f).ToString();
        }

        string getCurrentL1()
        {
            byte[] request =
            {
                0x00, 0x01,
                0x00, 0x00,
                0x00, 0x06,
                0x01,
                0x03,
                0x10, 0x10,
                0x00, 0x02
            };
            networkStream.Write(request, 0, request.Length);

            byte[] response = new byte[15];
            networkStream.Read(response, 0, response.Length);
            Console.WriteLine("Natezenie:\n" + BitConverter.ToString(response));

            byte[] currentL1Hex = new byte[4];
            Array.ConstrainedCopy(response, 9, currentL1Hex, 0, currentL1Hex.Length);
            Array.Reverse(currentL1Hex);
            return (BitConverter.ToUInt32(currentL1Hex, 0) / 1000f).ToString();
        }
        public string getCosPhi()
        {
            byte[] request =
            {
                0x00, 0x01,
                0x00, 0x00,
                0x00, 0x06,
                0x01,
                0x03,
                0x10, 0x20,
                0x00, 0x02
            };
            networkStream.Write(request, 0, request.Length);

            byte[] response = new byte[15];
            networkStream.Read(response, 0, response.Length);
            Console.WriteLine("Cos fi\n" + BitConverter.ToString(response));


            byte[] cosinusL1Hex = new byte[4];
            Array.ConstrainedCopy(response, 9, cosinusL1Hex, 0, cosinusL1Hex.Length);
            Array.Reverse(cosinusL1Hex);
            return (BitConverter.ToInt32(cosinusL1Hex, 0) / 1000f).ToString();
        }

        public string getActivePowerL1()
        {
            byte[] request =
            {
                0x00, 0x01,
                0x00, 0x00,
                0x00, 0x06,
                0x01,
                0x03,
                0x10, 0x30,
                0x00, 0x02
            };
            networkStream.Write(request, 0, request.Length);

            byte[] response = new byte[15];
            networkStream.Read(response, 0, response.Length);
            Console.WriteLine("Moc czynna:\n" + BitConverter.ToString(response));

            byte[] activePowerL1Hex = new byte[4];
            Array.ConstrainedCopy(response, 9, activePowerL1Hex, 0, activePowerL1Hex.Length);
            Array.Reverse(activePowerL1Hex);
            return (BitConverter.ToInt32(activePowerL1Hex, 0)).ToString();
        }

        public string getFrequencyL1()
        {
            byte[] request =
            {
                0x00, 0x01,
                0x00, 0x00,
                0x00, 0x06,
                0x01,
                0x03,
                0x10, 0x74,
                0x00, 0x02
            };
            networkStream.Write(request, 0, request.Length);

            byte[] response = new byte[15];
            networkStream.Read(response, 0, response.Length);
            Console.WriteLine("Częstotliwość :\n" + BitConverter.ToString(response));

            byte[] frequencyL1Hex = new byte[4];
            Array.ConstrainedCopy(response, 9, frequencyL1Hex, 0, frequencyL1Hex.Length);
            Array.Reverse(frequencyL1Hex);
            return (BitConverter.ToInt32(frequencyL1Hex, 0)).ToString();
        }

    }
}
