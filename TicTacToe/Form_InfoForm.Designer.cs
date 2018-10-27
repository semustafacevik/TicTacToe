namespace TicTacToe
{
    partial class frmInfoForm
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
            this.lblSocket = new MetroFramework.Controls.MetroLabel();
            this.pnlP1 = new System.Windows.Forms.Panel();
            this.btnOP1 = new MetroFramework.Controls.MetroButton();
            this.btnXP1 = new MetroFramework.Controls.MetroButton();
            this.lblNameP1 = new MetroFramework.Controls.MetroLabel();
            this.txtNameP1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblChoiceP1 = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.pnlP2 = new MetroFramework.Controls.MetroPanel();
            this.lblNameP2 = new MetroFramework.Controls.MetroLabel();
            this.btnOP2 = new MetroFramework.Controls.MetroButton();
            this.txtNameP2 = new MetroFramework.Controls.MetroTextBox();
            this.btnXP2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblChoiceP2 = new MetroFramework.Controls.MetroLabel();
            this.pnlP1.SuspendLayout();
            this.pnlP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSocket
            // 
            this.lblSocket.AutoSize = true;
            this.lblSocket.Location = new System.Drawing.Point(75, 127);
            this.lblSocket.Name = "lblSocket";
            this.lblSocket.Size = new System.Drawing.Size(170, 19);
            this.lblSocket.TabIndex = 13;
            this.lblSocket.Text = "X-O SELECTED BY PLAYER1";
            this.lblSocket.Visible = false;
            // 
            // pnlP1
            // 
            this.pnlP1.Controls.Add(this.btnOP1);
            this.pnlP1.Controls.Add(this.btnXP1);
            this.pnlP1.Controls.Add(this.lblNameP1);
            this.pnlP1.Controls.Add(this.txtNameP1);
            this.pnlP1.Controls.Add(this.metroLabel2);
            this.pnlP1.Controls.Add(this.lblChoiceP1);
            this.pnlP1.Location = new System.Drawing.Point(40, 18);
            this.pnlP1.Name = "pnlP1";
            this.pnlP1.Size = new System.Drawing.Size(103, 125);
            this.pnlP1.TabIndex = 12;
            // 
            // btnOP1
            // 
            this.btnOP1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOP1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOP1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnOP1.Location = new System.Drawing.Point(52, 76);
            this.btnOP1.Name = "btnOP1";
            this.btnOP1.Size = new System.Drawing.Size(30, 30);
            this.btnOP1.TabIndex = 4;
            this.btnOP1.Text = "O";
            this.btnOP1.UseCustomBackColor = true;
            this.btnOP1.UseSelectable = true;
            this.btnOP1.Click += new System.EventHandler(this.OnClick_XO);
            // 
            // btnXP1
            // 
            this.btnXP1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXP1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnXP1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnXP1.Location = new System.Drawing.Point(16, 76);
            this.btnXP1.Name = "btnXP1";
            this.btnXP1.Size = new System.Drawing.Size(30, 30);
            this.btnXP1.TabIndex = 5;
            this.btnXP1.Text = "X";
            this.btnXP1.UseCustomBackColor = true;
            this.btnXP1.UseSelectable = true;
            this.btnXP1.Click += new System.EventHandler(this.OnClick_XO);
            // 
            // lblNameP1
            // 
            this.lblNameP1.AutoSize = true;
            this.lblNameP1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNameP1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNameP1.Location = new System.Drawing.Point(0, 0);
            this.lblNameP1.Name = "lblNameP1";
            this.lblNameP1.Size = new System.Drawing.Size(72, 25);
            this.lblNameP1.TabIndex = 0;
            this.lblNameP1.Text = "PLAYER";
            // 
            // txtNameP1
            // 
            // 
            // 
            // 
            this.txtNameP1.CustomButton.Image = null;
            this.txtNameP1.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtNameP1.CustomButton.Name = "";
            this.txtNameP1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameP1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameP1.CustomButton.TabIndex = 1;
            this.txtNameP1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameP1.CustomButton.UseSelectable = true;
            this.txtNameP1.CustomButton.Visible = false;
            this.txtNameP1.Lines = new string[0];
            this.txtNameP1.Location = new System.Drawing.Point(0, 47);
            this.txtNameP1.MaxLength = 10;
            this.txtNameP1.Name = "txtNameP1";
            this.txtNameP1.PasswordChar = '\0';
            this.txtNameP1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameP1.SelectedText = "";
            this.txtNameP1.SelectionLength = 0;
            this.txtNameP1.SelectionStart = 0;
            this.txtNameP1.ShortcutsEnabled = true;
            this.txtNameP1.Size = new System.Drawing.Size(100, 23);
            this.txtNameP1.TabIndex = 3;
            this.txtNameP1.UseSelectable = true;
            this.txtNameP1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameP1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNameP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Name";
            // 
            // lblChoiceP1
            // 
            this.lblChoiceP1.AutoSize = true;
            this.lblChoiceP1.BackColor = System.Drawing.Color.Chocolate;
            this.lblChoiceP1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblChoiceP1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChoiceP1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChoiceP1.Location = new System.Drawing.Point(37, 76);
            this.lblChoiceP1.Name = "lblChoiceP1";
            this.lblChoiceP1.Size = new System.Drawing.Size(19, 25);
            this.lblChoiceP1.TabIndex = 6;
            this.lblChoiceP1.Text = "-";
            this.lblChoiceP1.UseCustomBackColor = true;
            this.lblChoiceP1.UseCustomForeColor = true;
            this.lblChoiceP1.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(123, 149);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.UseCustomBackColor = true;
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlP2
            // 
            this.pnlP2.BackColor = System.Drawing.Color.Transparent;
            this.pnlP2.Controls.Add(this.lblNameP2);
            this.pnlP2.Controls.Add(this.btnOP2);
            this.pnlP2.Controls.Add(this.txtNameP2);
            this.pnlP2.Controls.Add(this.btnXP2);
            this.pnlP2.Controls.Add(this.metroLabel4);
            this.pnlP2.Controls.Add(this.lblChoiceP2);
            this.pnlP2.HorizontalScrollbarBarColor = true;
            this.pnlP2.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlP2.HorizontalScrollbarSize = 10;
            this.pnlP2.Location = new System.Drawing.Point(184, 18);
            this.pnlP2.Name = "pnlP2";
            this.pnlP2.Size = new System.Drawing.Size(103, 125);
            this.pnlP2.TabIndex = 11;
            this.pnlP2.VerticalScrollbarBarColor = true;
            this.pnlP2.VerticalScrollbarHighlightOnWheel = false;
            this.pnlP2.VerticalScrollbarSize = 10;
            // 
            // lblNameP2
            // 
            this.lblNameP2.AutoSize = true;
            this.lblNameP2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNameP2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNameP2.Location = new System.Drawing.Point(0, 0);
            this.lblNameP2.Name = "lblNameP2";
            this.lblNameP2.Size = new System.Drawing.Size(72, 25);
            this.lblNameP2.TabIndex = 0;
            this.lblNameP2.Text = "PLAYER";
            // 
            // btnOP2
            // 
            this.btnOP2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOP2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOP2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnOP2.Location = new System.Drawing.Point(51, 76);
            this.btnOP2.Name = "btnOP2";
            this.btnOP2.Size = new System.Drawing.Size(30, 30);
            this.btnOP2.TabIndex = 4;
            this.btnOP2.Text = "O";
            this.btnOP2.UseCustomBackColor = true;
            this.btnOP2.UseSelectable = true;
            this.btnOP2.Click += new System.EventHandler(this.OnClick_XO);
            // 
            // txtNameP2
            // 
            // 
            // 
            // 
            this.txtNameP2.CustomButton.Image = null;
            this.txtNameP2.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtNameP2.CustomButton.Name = "";
            this.txtNameP2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameP2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameP2.CustomButton.TabIndex = 1;
            this.txtNameP2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameP2.CustomButton.UseSelectable = true;
            this.txtNameP2.CustomButton.Visible = false;
            this.txtNameP2.Lines = new string[0];
            this.txtNameP2.Location = new System.Drawing.Point(0, 47);
            this.txtNameP2.MaxLength = 10;
            this.txtNameP2.Name = "txtNameP2";
            this.txtNameP2.PasswordChar = '\0';
            this.txtNameP2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameP2.SelectedText = "";
            this.txtNameP2.SelectionLength = 0;
            this.txtNameP2.SelectionStart = 0;
            this.txtNameP2.ShortcutsEnabled = true;
            this.txtNameP2.Size = new System.Drawing.Size(100, 23);
            this.txtNameP2.TabIndex = 3;
            this.txtNameP2.UseSelectable = true;
            this.txtNameP2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameP2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNameP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnXP2
            // 
            this.btnXP2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXP2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnXP2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnXP2.Location = new System.Drawing.Point(15, 76);
            this.btnXP2.Name = "btnXP2";
            this.btnXP2.Size = new System.Drawing.Size(30, 30);
            this.btnXP2.TabIndex = 5;
            this.btnXP2.Text = "X";
            this.btnXP2.UseCustomBackColor = true;
            this.btnXP2.UseSelectable = true;
            this.btnXP2.Click += new System.EventHandler(this.OnClick_XO);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Name";
            // 
            // lblChoiceP2
            // 
            this.lblChoiceP2.AutoSize = true;
            this.lblChoiceP2.BackColor = System.Drawing.Color.Chocolate;
            this.lblChoiceP2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblChoiceP2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChoiceP2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChoiceP2.Location = new System.Drawing.Point(37, 76);
            this.lblChoiceP2.Name = "lblChoiceP2";
            this.lblChoiceP2.Size = new System.Drawing.Size(19, 25);
            this.lblChoiceP2.TabIndex = 6;
            this.lblChoiceP2.Text = "-";
            this.lblChoiceP2.UseCustomBackColor = true;
            this.lblChoiceP2.UseCustomForeColor = true;
            this.lblChoiceP2.Visible = false;
            // 
            // frmInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 185);
            this.Controls.Add(this.lblSocket);
            this.Controls.Add(this.pnlP1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlP2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.pnlP1.ResumeLayout(false);
            this.pnlP1.PerformLayout();
            this.pnlP2.ResumeLayout(false);
            this.pnlP2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblSocket;
        private System.Windows.Forms.Panel pnlP1;
        private MetroFramework.Controls.MetroButton btnOP1;
        private MetroFramework.Controls.MetroButton btnXP1;
        private MetroFramework.Controls.MetroLabel lblNameP1;
        private MetroFramework.Controls.MetroTextBox txtNameP1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblChoiceP1;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroPanel pnlP2;
        private MetroFramework.Controls.MetroLabel lblNameP2;
        private MetroFramework.Controls.MetroButton btnOP2;
        private MetroFramework.Controls.MetroTextBox txtNameP2;
        private MetroFramework.Controls.MetroButton btnXP2;
        private MetroFramework.Controls.MetroLabel lblChoiceP2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}