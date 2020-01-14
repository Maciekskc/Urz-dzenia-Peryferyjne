using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloototh
{
    public partial class AppForm : Form
    {
        private BluetoothDeviceInfo[] devices;
        private bool isPaired = false;
        private BluetoothDeviceInfo deviceToPair = null;
        private List<BluetoothDeviceInfo> connected = new List<BluetoothDeviceInfo>();

        public AppForm()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //czyszczenie listy urządzeń
            listBoxDevices.Items.Clear();

            //wyłączneie przycisku na czas wyszukania
            buttonFind.Enabled = false;
            
            
            //wyszukanie urządzeń i zrobienie z nich listy
            var bluetoothClient = new BluetoothClient();
            devices = bluetoothClient.DiscoverDevices();
            //włączenie przycisku po zakończeniu wyszukiwania i wypisamniu
            //wypisanie do text boxa
            foreach(BluetoothDeviceInfo device in devices)
            {
                listBoxDevices.Items.Add(device.DeviceName);
            }
            
            buttonFind.Enabled = true;

        }

        private void buttonPair_Click(object sender, EventArgs e)
        {
            //wybieramy urządzenie z listy
            foreach (BluetoothDeviceInfo device in devices)
            {
                if (device.DeviceName.Equals(listBoxDevices.SelectedItem))
                    deviceToPair = device;
            }

            //nawiżaywanie połączneia z wybranym urządzeniem
            deviceToPair.Update();
            deviceToPair.Refresh();
            deviceToPair.SetServiceState(BluetoothService.ObexObjectPush, true);

            //wysłanie podłączenia
            string pin = "1234";
            isPaired = BluetoothSecurity.PairRequest(deviceToPair.DeviceAddress, pin);

            //wypisanie wszystkich sparowanych urządzeń
            if (isPaired)
            {
                connected.Add(deviceToPair);
                listBoxConnected.Items.Clear();
                foreach (var device in connected)
                    listBoxConnected.Items.Add(device.DeviceName);
            }
        }

        private void buttonUnpair_Click(object sender, EventArgs e)
        {
            BluetoothSecurity.RemoveDevice(connected[listBoxConnected.SelectedIndex].DeviceAddress);

            connected.RemoveAt(listBoxConnected.SelectedIndex);
            listBoxConnected.Items.Clear();
            foreach (var device in connected)
                listBoxConnected.Items.Add(device.DeviceName);

            isPaired = false;
            deviceToPair = null;
        }
        
        private void buttonSendFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Task.Run(() =>
            {
                sendFileMethod(sender, this);
            }
            );
        }

        private void sendFileMethod(object sender, AppForm form)
        {
            OpenFileDialog dialog = (OpenFileDialog)sender;
            Console.WriteLine(dialog.ToString());
            var address = deviceToPair.DeviceAddress;

            SendFile(address, dialog.FileName);
        }

        public static ObexStatusCode SendFile(BluetoothAddress address, string file_path)
        {
            var obexUri = new Uri("obex://" + address + "/" + file_path);

            ObexWebRequest request = new ObexWebRequest(obexUri);

            ObexWebResponse response = null;

            request.ReadFile(file_path);
            try
            {
                response = (ObexWebResponse)request.GetResponse();
                response.Close();
                MessageBox.Show("Plik wysłany \n Kod odpowiedzi: " + response.StatusCode.ToString());
                return response.StatusCode;
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie udało się wysłać pliku:\n" + e.Message + " " + e.ToString());
            }


            return response.StatusCode;
        }
    }
}
