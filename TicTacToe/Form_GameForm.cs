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


namespace TicTacToe
{
    public partial class frmGameForm : MetroForm
    {
        Drawing CS_Drawing;

        public frmGameForm()
        {
            InitializeComponent();
        }

        private void pnlGame_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics graphic = pnlGame.CreateGraphics();
            CS_Drawing = new Drawing(graphic);
        }

        private void OnClick(object sender, EventArgs e)
        {
            MetroLabel clickedLabel = (MetroLabel)sender;

            MetroMessageBox.Show(this, clickedLabel.Name);
        }
    }
}
