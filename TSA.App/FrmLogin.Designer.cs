namespace TSA.App
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblInfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(103, 131);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(74, 21);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.EditValue = "Fuat";
            txtUsername.Location = new Point(183, 128);
            txtUsername.Name = "txtUsername";
            txtUsername.Properties.Appearance.Font = new Font("Times New Roman", 14.25F);
            txtUsername.Properties.Appearance.Options.UseFont = true;
            txtUsername.Size = new Size(124, 28);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.EditValue = "123";
            txtPassword.Location = new Point(183, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.Font = new Font("Times New Roman", 14.25F);
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.PasswordChar = '•';
            txtPassword.Size = new Size(124, 28);
            txtPassword.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(103, 165);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(74, 21);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Appearance.BackColor = Color.DarkGreen;
            btnLogin.Appearance.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLogin.Appearance.Options.UseBackColor = true;
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.ImeMode = ImeMode.On;
            btnLogin.Location = new Point(229, 196);
            btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(78, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.SeaGreen;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(labelControl4);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(pictureBox1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(376, 98);
            panelControl1.TabIndex = 5;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(205, 47);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(75, 31);
            labelControl4.TabIndex = 2;
            labelControl4.Text = "Log in";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(105, 10);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(262, 31);
            labelControl3.TabIndex = 1;
            labelControl3.Text = "Technical Service App";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(65, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(65, 158);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.Appearance.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblInfo.Appearance.ForeColor = Color.Red;
            lblInfo.Appearance.Options.UseFont = true;
            lblInfo.Appearance.Options.UseForeColor = true;
            lblInfo.Location = new Point(65, 227);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(31, 21);
            lblInfo.TabIndex = 8;
            lblInfo.Text = "Info";
            lblInfo.Visible = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 280);
            Controls.Add(lblInfo);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panelControl1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(labelControl2);
            Controls.Add(txtUsername);
            Controls.Add(labelControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DevExpress.XtraEditors.LabelControl lblInfo;
    }
}