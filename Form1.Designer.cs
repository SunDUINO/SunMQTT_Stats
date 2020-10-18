namespace SunMQTT_Stats
{
    partial class logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusCHK = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BrokerTxtB = new System.Windows.Forms.TextBox();
            this.PortTxtB = new System.Windows.Forms.TextBox();
            this.UserTxB = new System.Windows.Forms.TextBox();
            this.PasswordTxtB = new System.Windows.Forms.TextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnConnect = new System.Windows.Forms.PictureBox();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlStatus = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblVers = new System.Windows.Forms.Label();
            this.LblUtime = new System.Windows.Forms.Label();
            this.LblTStamp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConnect)).BeginInit();
            this.PnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.StatusCHK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 41);
            this.panel1.TabIndex = 0;
            // 
            // StatusCHK
            // 
            this.StatusCHK.Image = global::SunMQTT_Stats.Properties.Resources.wifi_512;
            this.StatusCHK.Location = new System.Drawing.Point(265, 6);
            this.StatusCHK.Name = "StatusCHK";
            this.StatusCHK.Size = new System.Drawing.Size(35, 31);
            this.StatusCHK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StatusCHK.TabIndex = 1;
            this.StatusCHK.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MQTT Connect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broker :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // BrokerTxtB
            // 
            this.BrokerTxtB.Location = new System.Drawing.Point(105, 76);
            this.BrokerTxtB.Name = "BrokerTxtB";
            this.BrokerTxtB.Size = new System.Drawing.Size(176, 20);
            this.BrokerTxtB.TabIndex = 5;
            // 
            // PortTxtB
            // 
            this.PortTxtB.Location = new System.Drawing.Point(105, 103);
            this.PortTxtB.Name = "PortTxtB";
            this.PortTxtB.Size = new System.Drawing.Size(176, 20);
            this.PortTxtB.TabIndex = 6;
            // 
            // UserTxB
            // 
            this.UserTxB.Location = new System.Drawing.Point(105, 130);
            this.UserTxB.Name = "UserTxB";
            this.UserTxB.Size = new System.Drawing.Size(176, 20);
            this.UserTxB.TabIndex = 7;
            // 
            // PasswordTxtB
            // 
            this.PasswordTxtB.Location = new System.Drawing.Point(105, 157);
            this.PasswordTxtB.Name = "PasswordTxtB";
            this.PasswordTxtB.Size = new System.Drawing.Size(176, 20);
            this.PasswordTxtB.TabIndex = 8;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::SunMQTT_Stats.Properties.Resources.footer_logo;
            this.PictureBox2.Location = new System.Drawing.Point(12, 211);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(100, 71);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 9;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Image = global::SunMQTT_Stats.Properties.Resources.icon_400_affiliate_whatsgreen3x_300x300;
            this.BtnConnect.Location = new System.Drawing.Point(223, 211);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 71);
            this.BtnConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.TabStop = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.panel1;
            this.dragControl.Vertical = true;
            // 
            // PnlStatus
            // 
            this.PnlStatus.Controls.Add(this.LblTStamp);
            this.PnlStatus.Controls.Add(this.LblUtime);
            this.PnlStatus.Controls.Add(this.LblVers);
            this.PnlStatus.Controls.Add(this.pictureBox3);
            this.PnlStatus.Controls.Add(this.pictureBox1);
            this.PnlStatus.Controls.Add(this.label8);
            this.PnlStatus.Controls.Add(this.label7);
            this.PnlStatus.Controls.Add(this.label6);
            this.PnlStatus.Location = new System.Drawing.Point(0, 40);
            this.PnlStatus.Name = "PnlStatus";
            this.PnlStatus.Size = new System.Drawing.Size(310, 259);
            this.PnlStatus.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Version :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "UpTime :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "TimeStamp :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SunMQTT_Stats.Properties.Resources.footer_logo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SunMQTT_Stats.Properties.Resources.icon_nav_close;
            this.pictureBox3.Location = new System.Drawing.Point(200, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // LblVers
            // 
            this.LblVers.AutoSize = true;
            this.LblVers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblVers.ForeColor = System.Drawing.Color.White;
            this.LblVers.Location = new System.Drawing.Point(97, 43);
            this.LblVers.Name = "LblVers";
            this.LblVers.Size = new System.Drawing.Size(34, 13);
            this.LblVers.TabIndex = 5;
            this.LblVers.Text = "label";
            // 
            // LblUtime
            // 
            this.LblUtime.AutoSize = true;
            this.LblUtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblUtime.ForeColor = System.Drawing.Color.White;
            this.LblUtime.Location = new System.Drawing.Point(97, 70);
            this.LblUtime.Name = "LblUtime";
            this.LblUtime.Size = new System.Drawing.Size(34, 13);
            this.LblUtime.TabIndex = 6;
            this.LblUtime.Text = "label";
            // 
            // LblTStamp
            // 
            this.LblTStamp.AutoSize = true;
            this.LblTStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblTStamp.ForeColor = System.Drawing.Color.White;
            this.LblTStamp.Location = new System.Drawing.Point(97, 97);
            this.LblTStamp.Name = "LblTStamp";
            this.LblTStamp.Size = new System.Drawing.Size(34, 13);
            this.LblTStamp.TabIndex = 7;
            this.LblTStamp.Text = "label";
            // 
            // logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(310, 298);
            this.Controls.Add(this.PnlStatus);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PasswordTxtB);
            this.Controls.Add(this.UserTxB);
            this.Controls.Add(this.PortTxtB);
            this.Controls.Add(this.BrokerTxtB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logowanie";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConnect)).EndInit();
            this.PnlStatus.ResumeLayout(false);
            this.PnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BrokerTxtB;
        private System.Windows.Forms.TextBox PortTxtB;
        private System.Windows.Forms.TextBox UserTxB;
        private System.Windows.Forms.TextBox PasswordTxtB;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox StatusCHK;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.Panel PnlStatus;
        private System.Windows.Forms.Label LblTStamp;
        private System.Windows.Forms.Label LblUtime;
        private System.Windows.Forms.Label LblVers;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

