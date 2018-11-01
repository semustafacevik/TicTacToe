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
            this.lblIP.Location = new System.Drawing.Point(212, 229);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(62, 23);
            this.lblIP.TabIndex = 13;
            this.lblIP.Text = "Server IP";
            this.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIP.Visible = false;
            // 
            // txtIP
            // 
            // 
            // 
            // 
            this.txtIP.CustomButton.Image = null;
            this.txtIP.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtIP.CustomButton.Name = "";
            this.txtIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIP.CustomButton.TabIndex = 1;
            this.txtIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIP.CustomButton.UseSelectable = true;
            this.txtIP.CustomButton.Visible = false;
            this.txtIP.Lines = new string[0];
            this.txtIP.Location = new System.Drawing.Point(280, 229);
            this.txtIP.MaxLength = 32767;
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.PromptText = "127.0.0.1 etc.";
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.SelectedText = "";
            this.txtIP.SelectionLength = 0;
            this.txtIP.SelectionStart = 0;
            this.txtIP.ShortcutsEnabled = true;
            this.txtIP.Size = new System.Drawing.Size(105, 23);
            this.txtIP.TabIndex = 12;
            this.txtIP.UseSelectable = true;
            this.txtIP.Visible = false;
            this.txtIP.WaterMark = "127.0.0.1 etc.";
            this.txtIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCreate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCreate.Location = new System.Drawing.Point(23, 196);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 27);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE SERVER";
            this.btnCreate.UseCustomBackColor = true;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.OnClick);
            // 
            // btnSocket
            // 
            this.btnSocket.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSocket.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSocket.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSocket.Location = new System.Drawing.Point(134, 196);
            this.btnSocket.Name = "btnSocket";
            this.btnSocket.Size = new System.Drawing.Size(140, 27);
            this.btnSocket.TabIndex = 6;
            this.btnSocket.Text = "SOCKET";
            this.btnSocket.UseCustomBackColor = true;
            this.btnSocket.UseSelectable = true;
            this.btnSocket.Click += new System.EventHandler(this.OnClick);
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnComputer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnComputer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnComputer.Location = new System.Drawing.Point(134, 63);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(140, 27);
            this.btnComputer.TabIndex = 7;
            this.btnComputer.Text = "COMPUTER";
            this.btnComputer.UseCustomBackColor = true;
            this.btnComputer.UseSelectable = true;
            this.btnComputer.Click += new System.EventHandler(this.OnClick);
            // 
            // btnTimed
            // 
            this.btnTimed.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTimed.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTimed.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnTimed.Location = new System.Drawing.Point(134, 153);
            this.btnTimed.Name = "btnTimed";
            this.btnTimed.Size = new System.Drawing.Size(140, 27);
            this.btnTimed.TabIndex = 8;
            this.btnTimed.Text = "TIMED";
            this.btnTimed.UseCustomBackColor = true;
            this.btnTimed.UseSelectable = true;
            this.btnTimed.Click += new System.EventHandler(this.OnClick);
            // 
            // btnFriend
            // 
            this.btnFriend.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFriend.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnFriend.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFriend.Location = new System.Drawing.Point(134, 108);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(140, 27);
            this.btnFriend.TabIndex = 9;
            this.btnFriend.Text = "FRIEND";
            this.btnFriend.UseCustomBackColor = true;
            this.btnFriend.UseSelectable = true;
            this.btnFriend.Click += new System.EventHandler(this.OnClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(134, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "GAME MODES";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnJoin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnJoin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnJoin.Location = new System.Drawing.Point(280, 196);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(105, 27);
            this.btnJoin.TabIndex = 10;
            this.btnJoin.Text = "JOIN SERVER";
            this.btnJoin.UseCustomBackColor = true;
            this.btnJoin.UseSelectable = true;
            this.btnJoin.Visible = false;
            this.btnJoin.Click += new System.EventHandler(this.OnClick);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Turquoise;
            this.btnConnect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConnect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnConnect.Location = new System.Drawing.Point(280, 196);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(105, 27);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseCustomBackColor = true;
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Visible = false;
            this.btnConnect.Click += new System.EventHandler(this.OnClick);
            // 
            // frmEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 267);
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

