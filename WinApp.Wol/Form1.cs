using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;

namespace WinApp.Wol
{
    public partial class Form1 : Form
    {
        private readonly string _regPath = @"SOFTWARE\MyWol";
        private readonly string _regKeyMac = "Mac";
        private readonly string _regKeyAddress = "Address";
        private readonly string _regKeyPort = "Port";

        public Form1()
        {
            InitializeComponent();

            // Get stored values from registry if any
            RegistryKey key = Registry.CurrentUser.CreateSubKey(_regPath);
            txtMac.Text = key.GetValue(_regKeyMac)?.ToString();
            txtAddress.Text = key.GetValue(_regKeyAddress)?.ToString();
            txtPort.Text = key.GetValue(_regKeyPort)?.ToString();
        }

        private async void BtnWake_Click(object sender, EventArgs e)
        {
            string strMac = txtMac.Text.Trim();
            string strAddress = txtAddress.Text.Trim();
            string strPort = txtPort.Text.Trim();

            lblStatus.Text = string.Empty;

            if (string.IsNullOrEmpty(strMac) || string.IsNullOrEmpty(strAddress) || string.IsNullOrEmpty(strPort))
            {
                MessageBox.Show("Please enter all the values.");
            }
            else
            {
                btnWake.Enabled = false;

                try
                {
                    var target = PhysicalAddress.Parse(strMac);
                    var header = Enumerable.Repeat(byte.MaxValue, 6);
                    var data = Enumerable.Repeat(target.GetAddressBytes(), 16).SelectMany(mac => mac);
                    var magicPacket = header.Concat(data).ToArray();

                    var myIP = Dns.GetHostAddresses(strAddress)[0];
                    _ = int.TryParse(strPort, out int port);

                    lblStatus.Text = "Sending...";

                    using (var client = new UdpClient())
                    {
                        await client.SendAsync(magicPacket, magicPacket.Length, new IPEndPoint(myIP, port));
                    }

                    // Store values into registry
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(_regPath);
                    key.SetValue(_regKeyMac, txtMac.Text.Trim());
                    key.SetValue(_regKeyAddress, txtAddress.Text.Trim());
                    key.SetValue(_regKeyPort, port);

                    lblStatus.Text = "Packet Sent.";
                }
                catch(Exception ex)
                {
                    lblStatus.Text = string.Empty;
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnWake.Enabled = true;
                }
            }
        }
    }
}
