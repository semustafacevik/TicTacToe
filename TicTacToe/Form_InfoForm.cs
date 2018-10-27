using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;

namespace TicTacToe
{
    public partial class frmInfoForm : MetroFramework.Forms.MetroForm
    {
        Player1 P1 = new Player1();
        Player2 P2 = new Player2();

        public frmInfoForm(string gameMode)
        {
            InitializeComponent();
            FormRegulations(gameMode);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }



        private void FormRegulations(string gameMode)
        {
            switch (gameMode)
            {
                case "FRIEND":
                    lblNameP1.Text = "PLAYER1";
                    lblNameP2.Text = "PLAYER2";
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
    }
}
