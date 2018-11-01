using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TicTacToe
{
    public partial class frmEntryForm : MetroForm
    {
        public static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private const int _PORT = 44566;

        frmInfoForm Form_Info;

        public frmEntryForm()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            MetroButton clickedButton = (MetroButton)sender;
            string buttonText = clickedButton.Text;
            string buttonName = clickedButton.Name;

            switch (buttonName)
            {
                case "btnSocket":
                    btnCreate.Show();
                    btnJoin.Show();
                    btnSocket.Text = "<<  --  >>";
                    break;

                case "btnCreate":
                    IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), _PORT);

                    try
                    {
                        CreateServer();
                        socket.Connect(localEndPoint);
                        Form_Info = new frmInfoForm(buttonText);
                        Form_Info.ShowDialog();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Server couldn't be created", "ERROR", 100);
                    }

                    break;

                case "btnJoin":
                    lblIP.Show();                   
                    txtIP.Show();
                    btnConnect.Show();
                    btnJoin.Hide();
                    break;

                case "btnConnect":

                    string serverIP = txtIP.Text;
                    MetroMessageBox.Show(this, "Connecting to server (" + serverIP + ")", "", 100);

                    try
                    {
                        socket.Connect(new IPEndPoint(IPAddress.Parse(serverIP), _PORT));
                        MetroMessageBox.Show(this, "Successfully connected", "", 100); // Server was connected successfully

                        Form_Info = new frmInfoForm(buttonText);
                        Form_Info.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Failed to connect to server (" + ex.Message + ")", "ERROR");
                    }

                    break;

                default:
                    Form_Info = new frmInfoForm(buttonText);
                    Form_Info.ShowDialog();
                    break;
            }

            
        }

        private void CreateServer()
        {
            string path = System.Windows.Forms.Application.StartupPath;
            DirectoryInfo di = Directory.GetParent(path);
            DirectoryInfo di2 = Directory.GetParent(di.ToString());
            DirectoryInfo di3 = Directory.GetParent(di2.ToString());

            string editedPath = di3.ToString();
            editedPath += @"\GameServer\bin\Debug\GameServer.exe";

            System.Diagnostics.Process.Start(editedPath);
        }
    }
}