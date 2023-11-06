using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace prelab1._2
{
    public partial class Form1 : Form
    {
        bool terminating = false;
        bool connected = false;
        Socket clientSocket;
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            string name = name_text_box.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z0-9 ]*$") )
            {
                log.AppendText("wrong name format");
                return;
            }
                
            
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = ip_text_box.Text;
            int portNum;
            if(Int32.TryParse(port_text_box.Text, out portNum))
            {
                try
                {
                    clientSocket.Connect(IP, portNum);
                    button_connect.Enabled = false;
                    connected = true;
                    log.AppendText("success");
                    //send the name first
                    Byte[] buffer = Encoding.Default.GetBytes(name);
                    clientSocket.Send(buffer);
                    log.AppendText("message sent: " + name);
                    //start receiving
                    Thread receiveThread = new Thread(Receive);
                    receiveThread.Start();
                }
                catch
                {
                    log.AppendText("Could not connect to the server!\n");
                }
            }
            else
            {
                log.AppendText("Check the port\n");
            }

        }


        private void Receive()
        {
            while(connected)
            {
                try
                {
                    Byte[] buffer = new Byte[64];
                    clientSocket.Receive(buffer);
                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));

                    log.AppendText("Server: " + incomingMessage + "\n");
                    clientSocket.Close();
                    connected = false;
                    button_connect.Enabled = true;

                }
                catch
                {
                    if (!terminating)
                    {
                        log.AppendText("The server has disconnected\n");
                        button_connect.Enabled = true;
                    }

                    clientSocket.Close();
                    connected = false;


                }
            }


        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }
    }
}
