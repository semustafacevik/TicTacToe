using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace TicTacToe
{
    public partial class frmInfoForm : MetroForm
    {
        frmGameForm Form_Game;
        Player1 P1 = new Player1();
        Player2 P2 = new Player2();

        string gameMode;
        public frmInfoForm(string gameMode)
        {
            InitializeComponent();
            this.gameMode = gameMode;
            FormRegulations(gameMode);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            P1.name = txtNameP1.Text;
            P2.name = txtNameP2.Text;

            switch (gameMode)
            {
                case "CREATE SERVER":
                    CheckName_P1();
                    CheckXO();

                    string sendMessage_P1 = "Name=" + P1.name + " " + P1.choice + "P1";
                    byte[] message_P1 = Encoding.UTF8.GetBytes(sendMessage_P1);

                    frmEntryForm.socket.Send(message_P1);

                    break;

                case "CONNECT":
                    CheckName_P2();

                    string sendMessage_P2 = "Name=" + P2.name + " " + P2.choice + "P2";
                    byte[] message_P2 = Encoding.UTF8.GetBytes(sendMessage_P2);

                    frmEntryForm.socket.Send(message_P2);

                    break;

                default:
                    CheckName_P1();
                    CheckName_P2();
                    CheckXO();

                    if (gameMode == "COMPUTER")
                        P2.name = "Computer";

                    break;
            }

            Close();
            Form_Game = new frmGameForm(gameMode, P1, P2);
            Form_Game.Show();


        }

        private void OnClick_XO(object sender, EventArgs e)
        {
            MetroButton clickedButton = (MetroButton)sender;
            string buttonName = clickedButton.Name;

            switch (buttonName)
            {
                case "btnXP1":
                    P1.choice = "X";
                    P2.choice = "O";
                    break;

                case "btnXP2":
                    P2.choice = "X";
                    P1.choice = "O";
                    break;

                case "btnOP1":
                    P1.choice = "O";
                    P2.choice = "X";
                    break;

                case "btnOP2":
                    P2.choice = "O";
                    P1.choice = "X";
                    break;

                default:
                    break;
            }

            ButtonRegulations();
        }



        private void FormRegulations(string gameMode)
        {
            switch (gameMode)
            {
                case "FRIEND":
                    lblNameP1.Text = "PLAYER 1";
                    lblNameP2.Text = "PLAYER 2";
                    break;

                case "COMPUTER":
                case "CREATE SERVER":
                    pnlP2.Hide();
                    pnlP1.Location = new Point(110, 20);
                    break;

                case "CONNECT":
                    lblSocket.Show();
                    pnlP1.Hide();
                    pnlP2.Location = new Point(110, 20);
                    btnXP2.Enabled = false;
                    btnOP2.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        private void ButtonRegulations()
        {
            btnXP1.Hide();
            btnOP1.Hide();
            btnXP2.Hide();
            btnOP2.Hide();
            lblChoiceP1.Show();
            lblChoiceP2.Show();
            lblChoiceP1.Text = P1.choice;
            lblChoiceP2.Text = P2.choice;
        } 

        private void CheckName_P1()
        {
            if (txtNameP1.Text == "")
                P1.name = "Player_1";
        }

        private void CheckName_P2()
        {
            if (txtNameP2.Text == "")
                P2.name = "Player_2";
        }

        private void CheckXO()
        {
            if (P1.choice == null)
            {
                P1.choice = "X";
                P2.choice = "O";
            }
        }

        private void txtName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }
    }
}
