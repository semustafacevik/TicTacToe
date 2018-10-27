using System;


namespace TicTacToe
{
    partial class frmGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lblNameP1 = new MetroFramework.Controls.MetroLabel();
            this.lblNameP2 = new MetroFramework.Controls.MetroLabel();
            this.lblScoreP1 = new MetroFramework.Controls.MetroLabel();
            this.lblScoreP2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblScoreDraw = new MetroFramework.Controls.MetroLabel();
            this.lblChoiceP1 = new MetroFramework.Controls.MetroLabel();
            this.lblChoiceP2 = new MetroFramework.Controls.MetroLabel();
            this.pnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.Controls.Add(this.lbl8);
            this.pnlGame.Controls.Add(this.lbl5);
            this.pnlGame.Controls.Add(this.lbl2);
            this.pnlGame.Controls.Add(this.lbl7);
            this.pnlGame.Controls.Add(this.lbl4);
            this.pnlGame.Controls.Add(this.lbl6);
            this.pnlGame.Controls.Add(this.lbl1);
            this.pnlGame.Controls.Add(this.lbl3);
            this.pnlGame.Controls.Add(this.lbl0);
            this.pnlGame.Location = new System.Drawing.Point(69, 31);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(300, 300);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.Color.Transparent;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl8.Location = new System.Drawing.Point(205, 205);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(90, 90);
            this.lbl8.TabIndex = 1;
            this.lbl8.Text = "O";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl8.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl5.Location = new System.Drawing.Point(205, 105);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(90, 90);
            this.lbl5.TabIndex = 1;
            this.lbl5.Text = "O";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(205, 5);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(90, 90);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "O";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.Transparent;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl7.Location = new System.Drawing.Point(105, 205);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(90, 90);
            this.lbl7.TabIndex = 1;
            this.lbl7.Text = "O";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl7.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl4.Location = new System.Drawing.Point(105, 105);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(90, 90);
            this.lbl4.TabIndex = 1;
            this.lbl4.Text = "O";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl4.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl6.Location = new System.Drawing.Point(5, 205);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(90, 90);
            this.lbl6.TabIndex = 1;
            this.lbl6.Text = "O";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl6.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(105, 5);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 90);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "O";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(5, 105);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(90, 90);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "O";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl0.Location = new System.Drawing.Point(5, 5);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(90, 90);
            this.lbl0.TabIndex = 1;
            this.lbl0.Text = "O";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl0.Click += new System.EventHandler(this.OnClick);
            // 
            // lblNameP1
            // 
            this.lblNameP1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNameP1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNameP1.Location = new System.Drawing.Point(23, 348);
            this.lblNameP1.Name = "lblNameP1";
            this.lblNameP1.Size = new System.Drawing.Size(150, 25);
            this.lblNameP1.TabIndex = 1;
            this.lblNameP1.Text = "P1";
            // 
            // lblNameP2
            // 
            this.lblNameP2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNameP2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNameP2.Location = new System.Drawing.Point(266, 348);
            this.lblNameP2.Name = "lblNameP2";
            this.lblNameP2.Size = new System.Drawing.Size(150, 25);
            this.lblNameP2.TabIndex = 1;
            this.lblNameP2.Text = "P2";
            this.lblNameP2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScoreP1
            // 
            this.lblScoreP1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblScoreP1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblScoreP1.Location = new System.Drawing.Point(23, 373);
            this.lblScoreP1.Name = "lblScoreP1";
            this.lblScoreP1.Size = new System.Drawing.Size(50, 25);
            this.lblScoreP1.TabIndex = 1;
            this.lblScoreP1.Text = "0";
            // 
            // lblScoreP2
            // 
            this.lblScoreP2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblScoreP2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblScoreP2.Location = new System.Drawing.Point(366, 373);
            this.lblScoreP2.Name = "lblScoreP2";
            this.lblScoreP2.Size = new System.Drawing.Size(50, 25);
            this.lblScoreP2.TabIndex = 1;
            this.lblScoreP2.Text = "0";
            this.lblScoreP2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(172, 348);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 25);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "DRAW";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScoreDraw
            // 
            this.lblScoreDraw.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblScoreDraw.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblScoreDraw.Location = new System.Drawing.Point(172, 373);
            this.lblScoreDraw.Name = "lblScoreDraw";
            this.lblScoreDraw.Size = new System.Drawing.Size(100, 25);
            this.lblScoreDraw.TabIndex = 1;
            this.lblScoreDraw.Text = "0";
            this.lblScoreDraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChoiceP1
            // 
            this.lblChoiceP1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblChoiceP1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChoiceP1.Location = new System.Drawing.Point(23, 323);
            this.lblChoiceP1.Name = "lblChoiceP1";
            this.lblChoiceP1.Size = new System.Drawing.Size(50, 25);
            this.lblChoiceP1.TabIndex = 1;
            this.lblChoiceP1.Text = "*";
            // 
            // lblChoiceP2
            // 
            this.lblChoiceP2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblChoiceP2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChoiceP2.Location = new System.Drawing.Point(366, 323);
            this.lblChoiceP2.Name = "lblChoiceP2";
            this.lblChoiceP2.Size = new System.Drawing.Size(50, 25);
            this.lblChoiceP2.TabIndex = 1;
            this.lblChoiceP2.Text = "*";
            this.lblChoiceP2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 413);
            this.Controls.Add(this.lblChoiceP2);
            this.Controls.Add(this.lblScoreP2);
            this.Controls.Add(this.lblScoreDraw);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblNameP2);
            this.Controls.Add(this.lblChoiceP1);
            this.Controls.Add(this.lblScoreP1);
            this.Controls.Add(this.lblNameP1);
            this.Controls.Add(this.pnlGame);
            this.Name = "frmGameForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.pnlGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private MetroFramework.Controls.MetroLabel lblNameP1;
        private MetroFramework.Controls.MetroLabel lblNameP2;
        private MetroFramework.Controls.MetroLabel lblScoreP1;
        private MetroFramework.Controls.MetroLabel lblScoreP2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblScoreDraw;
        private MetroFramework.Controls.MetroLabel lblChoiceP1;
        private MetroFramework.Controls.MetroLabel lblChoiceP2;
    }
}