namespace TicTacToe
{
    partial class frmEntryForm
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
            this.lblIP = new MetroFramework.Controls.MetroLabel();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.btnSocket = new MetroFramework.Controls.MetroButton();
            this.btnComputer = new MetroFramework.Controls.MetroButton();
            this.btnTimed = new MetroFramework.Controls.MetroButton();
            this.btnFriend = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnJoin = new MetroFramework.Controls.MetroButton();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(187, 223);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(62, 19);
            this.lblIP.TabIndex = 13;
            this.lblIP.Text = "Server IP";
            this.lblIP.Visible = false;
            // 
            // txtIP
            // 
            // 
            // 
            // 
            this.txtIP.CustomButton.Image = null;
            this.txtIP.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtIP.CustomButton.Name = "";
            this.txtIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIP.CustomButton.TabIndex = 1;
            this.txtIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIP.CustomButton.UseSelectable = true;
            this.txtIP.CustomButton.Visible = false;
            this.txtIP.Lines = new string[0];
            this.txtIP.Location = new System.Drawing.Point(255, 223);
            this.txtIP.MaxLength = 32767;
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.SelectedText = "";
            this.txtIP.SelectionLength = 0;
            this.txtIP.SelectionStart = 0;
            this.txtIP.ShortcutsEnabled = true;
            this.txtIP.Size = new System.Drawing.Size(92, 23);
            this.txtIP.TabIndex = 12;
            this.txtIP.UseSelectable = true;
            this.txtIP.Visible = false;
            this.txtIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 194);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE SERVER";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.OnClick);
            // 
            // btnSocket
            // 
            this.btnSocket.Location = new System.Drawing.Point(109, 194);
            this.btnSocket.Name = "btnSocket";
            this.btnSocket.Size = new System.Drawing.Size(140, 23);
            this.btnSocket.TabIndex = 6;
            this.btnSocket.Text = "SOCKET";
            this.btnSocket.UseSelectable = true;
            this.btnSocket.Click += new System.EventHandler(this.OnClick);
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(109, 61);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(140, 23);
            this.btnComputer.TabIndex = 7;
            this.btnComputer.Text = "COMPUTER";
            this.btnComputer.UseSelectable = true;
            this.btnComputer.Click += new System.EventHandler(this.OnClick);
            // 
            // btnTimed
            // 
            this.btnTimed.Location = new System.Drawing.Point(109, 151);
            this.btnTimed.Name = "btnTimed";
            this.btnTimed.Size = new System.Drawing.Size(140, 23);
            this.btnTimed.TabIndex = 8;
            this.btnTimed.Text = "TIMED";
            this.btnTimed.UseSelectable = true;
            this.btnTimed.Click += new System.EventHandler(this.OnClick);
            // 
            // btnFriend
            // 
            this.btnFriend.Location = new System.Drawing.Point(109, 106);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(140, 23);
            this.btnFriend.TabIndex = 9;
            this.btnFriend.Text = "FRIEND";
            this.btnFriend.UseSelectable = true;
            this.btnFriend.Click += new System.EventHandler(this.OnClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(118, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "GAME MODES";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(255, 194);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(92, 23);
            this.btnJoin.TabIndex = 10;
            this.btnJoin.Text = "JOIN SERVER";
            this.btnJoin.UseSelectable = true;
            this.btnJoin.Visible = false;
            this.btnJoin.Click += new System.EventHandler(this.OnClick);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(255, 194);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Visible = false;
            this.btnConnect.Click += new System.EventHandler(this.OnClick);
            // 
            // frmEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 260);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSocket);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.btnTimed);
            this.Controls.Add(this.btnFriend);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnConnect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntryForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblIP;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton btnSocket;
        private MetroFramework.Controls.MetroButton btnComputer;
        private MetroFramework.Controls.MetroButton btnTimed;
        private MetroFramework.Controls.MetroButton btnFriend;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnJoin;
        private MetroFramework.Controls.MetroButton btnConnect;
    }
}

