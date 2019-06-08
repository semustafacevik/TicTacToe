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
using System.Diagnostics;

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

        /// <summary>
        /// Clicking game modes
        /// </summary>
        /// <param name="sender">clicked button</param>
        /// <param name="e">event args</param>
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
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Server couldn't be created (" + ex.Message + ")", "ERROR");
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
            }//controls          
        }

        /// <summary>
        /// Server creation method -GameServer.exe-
        /// </summary>
        private void CreateServer()
        {
            ShutdownServer();
            string path = System.Windows.Forms.Application.StartupPath;
            DirectoryInfo dirInfo = Directory.GetParent(path).Parent.Parent;
            string editedPath = dirInfo.FullName.ToString();
            editedPath += @"\GameServer\bin\Debug\GameServer.exe"; // GameServer.exe path

            Process.Start(editedPath);
        }

        /// <summary>
        /// Server shutdown method -GameServer.exe-
        /// </summary>
        private void ShutdownServer()
        {
            foreach (var server in Process.GetProcessesByName("GameServer"))
            {
                server.Kill();
            }
        }

        private void frmEntryForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            ShutdownServer();
        }
    }
}