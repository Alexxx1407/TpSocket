using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Socket SSockUDP;
        Timer monTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateS_Click(object sender, EventArgs e)
        {
            try
            {
                SSockUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            }
            catch (System.Net.Sockets.SocketException se)
            {
                this.textBoxReceiveS.Text += "Message d’erreur : " + se.ToString() + Environment.NewLine;
            }

        }
        // a
        private void buttonSendS_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint iped = new IPEndPoint(IPAddress.Parse(this.textBoxIPS.Text), int.Parse(this.textBoxPortS.Text));
                SSockUDP.Connect(iped);
                var messageEnvoi = Encoding.ASCII.GetBytes(this.textBoxSendS.Text);
                SSockUDP.Send(messageEnvoi);
            }
            catch (System.Net.Sockets.SocketException se)
            {
                this.textBoxReceiveS.Text += "Message d’erreur : " + se.ToString() + Environment.NewLine;
            }
            catch (System.FormatException se)
            {
                this.textBoxReceiveS.Text += "Message d’erreur : " + se.ToString() + Environment.NewLine;
            }
            catch (System.NullReferenceException)
            {
                this.textBoxReceiveS.Text += "Erreur : Socket inexistante" + Environment.NewLine;
            }
        }
    }
}