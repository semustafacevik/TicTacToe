﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Net;
using System.Net.Sockets;

namespace TicTacToe
{
    public partial class frmEntryForm : MetroFramework.Forms.MetroForm
    {
        public static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private const int _PORT = 44644;

        frmInfoForm Form_Info;

        public frmEntryForm()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            switch (clickedButton.Name)
            {
                case "btnSocket":
                    btnCreate.Show();
                    btnJoin.Show();
                    btnSocket.Text = "<<  --  >>";
                    break;

                case "btnCreate":
                    //string myPath = @"C:\Users\MustafaCevik\source\repos\MyServer\MyServer\bin\Debug\MyServer.exe";
                    //System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    //prc.StartInfo.FileName = myPath;
                    //prc.Start();

                    IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), _PORT);

                    try
                    {
                        socket.Connect(localEndPoint);
                        Form_Info = new frmInfoForm(clickedButton.Text);
                        Form_Info.ShowDialog();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Server couldn't be created");
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
                    MetroMessageBox.Show(this, "Connecting to server (" + serverIP + ")");

                    try
                    {
                        socket.Connect(new IPEndPoint(IPAddress.Parse(serverIP), _PORT));
                        MetroMessageBox.Show(this, "Successfully connetted");

                        Form_Info = new frmInfoForm(clickedButton.Text);
                        Form_Info.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Failed to connect to server (" + ex.Message + ")");
                    }

                    break;

                default:
                    Form_Info = new frmInfoForm(clickedButton.Text);
                    Form_Info.ShowDialog();
                    break;
            }

            
        }
    }
}