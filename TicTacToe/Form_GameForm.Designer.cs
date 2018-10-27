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
            this.lbl8 = new MetroFramework.Controls.MetroLabel();
            this.lbl5 = new MetroFramework.Controls.MetroLabel();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.lbl7 = new MetroFramework.Controls.MetroLabel();
            this.lbl4 = new MetroFramework.Controls.MetroLabel();
            this.lbl6 = new MetroFramework.Controls.MetroLabel();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.lbl3 = new MetroFramework.Controls.MetroLabel();
            this.lbl0 = new MetroFramework.Controls.MetroLabel();
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
            this.lbl8.Location = new System.Drawing.Point(205, 205);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(90, 90);
            this.lbl8.TabIndex = 1;
            this.lbl8.UseCustomBackColor = true;
            this.lbl8.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Location = new System.Drawing.Point(205, 105);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(90, 90);
            this.lbl5.TabIndex = 1;
            this.lbl5.UseCustomBackColor = true;
            this.lbl5.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Location = new System.Drawing.Point(205, 5);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(90, 90);
            this.lbl2.TabIndex = 1;
            this.lbl2.UseCustomBackColor = true;
            this.lbl2.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.Transparent;
            this.lbl7.Location = new System.Drawing.Point(105, 205);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(90, 90);
            this.lbl7.TabIndex = 1;
            this.lbl7.UseCustomBackColor = true;
            this.lbl7.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Location = new System.Drawing.Point(105, 105);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(90, 90);
            this.lbl4.TabIndex = 1;
            this.lbl4.UseCustomBackColor = true;
            this.lbl4.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Location = new System.Drawing.Point(5, 205);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(90, 90);
            this.lbl6.TabIndex = 1;
            this.lbl6.UseCustomBackColor = true;
            this.lbl6.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Location = new System.Drawing.Point(105, 5);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 90);
            this.lbl1.TabIndex = 1;
            this.lbl1.UseCustomBackColor = true;
            this.lbl1.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Location = new System.Drawing.Point(5, 105);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(90, 90);
            this.lbl3.TabIndex = 1;
            this.lbl3.UseCustomBackColor = true;
            this.lbl3.Click += new System.EventHandler(this.OnClick);
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.Location = new System.Drawing.Point(5, 5);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(90, 90);
            this.lbl0.TabIndex = 1;
            this.lbl0.UseCustomBackColor = true;
            this.lbl0.Click += new System.EventHandler(this.OnClick);
            // 
            // frmGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 379);
            this.Controls.Add(this.pnlGame);
            this.Name = "frmGameForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.pnlGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlGame;
        private MetroFramework.Controls.MetroLabel lbl0;
        private MetroFramework.Controls.MetroLabel lbl8;
        private MetroFramework.Controls.MetroLabel lbl5;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroLabel lbl7;
        private MetroFramework.Controls.MetroLabel lbl4;
        private MetroFramework.Controls.MetroLabel lbl6;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroLabel lbl3;
    }
}