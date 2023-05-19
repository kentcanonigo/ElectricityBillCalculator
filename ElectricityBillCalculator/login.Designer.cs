namespace ElectricityBillCalculator
{
    partial class login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            usernameTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            loginBtn = new Button();
            registerBtn = new Button();
            showPassBtn = new PictureBox();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            signUp2Lbl = new Label();
            signUp1Lbl = new Label();
            twtBtn = new roundBtn();
            fbBtn = new roundBtn();
            googBtn = new roundBtn();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            wpSignupPbx = new PictureBox();
            usernamePanel = new Panel();
            passwordPanel = new Panel();
            loginClose = new Button();
            loginRestore = new Button();
            loginMinimize = new Button();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wpSignupPbx).BeginInit();
            passwordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.BackColor = SystemColors.InactiveCaption;
            usernameTxtBox.BorderStyle = BorderStyle.None;
            usernameTxtBox.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTxtBox.Location = new Point(155, 383);
            usernameTxtBox.Multiline = true;
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.PlaceholderText = "Username";
            usernameTxtBox.Size = new Size(457, 34);
            usernameTxtBox.TabIndex = 0;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.BackColor = SystemColors.InactiveCaption;
            passwordTxtBox.BorderStyle = BorderStyle.None;
            passwordTxtBox.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxtBox.Location = new Point(155, 456);
            passwordTxtBox.Multiline = true;
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '•';
            passwordTxtBox.PlaceholderText = "Password";
            passwordTxtBox.Size = new Size(457, 34);
            passwordTxtBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.PowderBlue;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Moon", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(281, 519);
            loginBtn.Margin = new Padding(0);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(264, 61);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.PowderBlue;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Moon", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(958, 445);
            registerBtn.Margin = new Padding(0);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(264, 61);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Sign Up";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // showPassBtn
            // 
            showPassBtn.BackColor = SystemColors.InactiveCaption;
            showPassBtn.Cursor = Cursors.Hand;
            showPassBtn.Image = Properties.Resources.hidePass;
            showPassBtn.Location = new Point(466, 5);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(68, 57);
            showPassBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            showPassBtn.TabIndex = 6;
            showPassBtn.TabStop = false;
            showPassBtn.Click += showPassBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Moon", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(408, 341);
            label1.Name = "label1";
            label1.Size = new Size(24, 14);
            label1.TabIndex = 8;
            label1.Text = "OR";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Avoda", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(253, 231);
            label2.Name = "label2";
            label2.Size = new Size(348, 42);
            label2.TabIndex = 12;
            label2.Text = "Login using social networks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("ArterioNonCommercial", 34.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 174);
            label3.Name = "label3";
            label3.Size = new Size(754, 57);
            label3.TabIndex = 13;
            label3.Text = "Login to Your Account";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(63, 347);
            label4.Name = "label4";
            label4.Size = new Size(345, 3);
            label4.TabIndex = 14;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(433, 347);
            label5.Name = "label5";
            label5.Size = new Size(345, 3);
            label5.TabIndex = 15;
            // 
            // signUp2Lbl
            // 
            signUp2Lbl.AutoSize = true;
            signUp2Lbl.BackColor = Color.Transparent;
            signUp2Lbl.Cursor = Cursors.IBeam;
            signUp2Lbl.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            signUp2Lbl.ForeColor = Color.White;
            signUp2Lbl.Location = new Point(912, 367);
            signUp2Lbl.Name = "signUp2Lbl";
            signUp2Lbl.Size = new Size(356, 66);
            signUp2Lbl.TabIndex = 16;
            signUp2Lbl.Text = "Sign up and discover a great\r\namount of opportunities!\r\n";
            signUp2Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signUp1Lbl
            // 
            signUp1Lbl.AutoSize = true;
            signUp1Lbl.BackColor = Color.Transparent;
            signUp1Lbl.CausesValidation = false;
            signUp1Lbl.Cursor = Cursors.IBeam;
            signUp1Lbl.FlatStyle = FlatStyle.Flat;
            signUp1Lbl.Font = new Font("Moon", 37.8F, FontStyle.Bold, GraphicsUnit.Point);
            signUp1Lbl.ForeColor = Color.White;
            signUp1Lbl.Location = new Point(895, 291);
            signUp1Lbl.Name = "signUp1Lbl";
            signUp1Lbl.Size = new Size(390, 66);
            signUp1Lbl.TabIndex = 17;
            signUp1Lbl.Text = "New Here?";
            signUp1Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // twtBtn
            // 
            twtBtn.BackColor = SystemColors.Control;
            twtBtn.BackgroundImage = Properties.Resources.twtFin;
            twtBtn.BackgroundImageLayout = ImageLayout.Center;
            twtBtn.Cursor = Cursors.Hand;
            twtBtn.FlatAppearance.BorderSize = 0;
            twtBtn.FlatStyle = FlatStyle.Flat;
            twtBtn.Location = new Point(462, 273);
            twtBtn.Name = "twtBtn";
            twtBtn.Size = new Size(62, 62);
            twtBtn.TabIndex = 20;
            twtBtn.UseVisualStyleBackColor = false;
            // 
            // fbBtn
            // 
            fbBtn.BackColor = SystemColors.Control;
            fbBtn.BackgroundImage = (Image)resources.GetObject("fbBtn.BackgroundImage");
            fbBtn.BackgroundImageLayout = ImageLayout.Center;
            fbBtn.Cursor = Cursors.Hand;
            fbBtn.FlatAppearance.BorderSize = 0;
            fbBtn.FlatStyle = FlatStyle.Flat;
            fbBtn.Location = new Point(309, 273);
            fbBtn.Name = "fbBtn";
            fbBtn.Size = new Size(62, 62);
            fbBtn.TabIndex = 21;
            fbBtn.UseVisualStyleBackColor = false;
            // 
            // googBtn
            // 
            googBtn.BackColor = SystemColors.Control;
            googBtn.BackgroundImage = (Image)resources.GetObject("googBtn.BackgroundImage");
            googBtn.BackgroundImageLayout = ImageLayout.Center;
            googBtn.Cursor = Cursors.Hand;
            googBtn.FlatAppearance.BorderSize = 0;
            googBtn.FlatStyle = FlatStyle.Flat;
            googBtn.Location = new Point(386, 273);
            googBtn.Name = "googBtn";
            googBtn.Size = new Size(62, 62);
            googBtn.TabIndex = 22;
            googBtn.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 20;
            bunifuElipse1.TargetControl = this;
            // 
            // wpSignupPbx
            // 
            wpSignupPbx.BackColor = Color.Black;
            wpSignupPbx.BackgroundImage = Properties.Resources.wpSignUpBg;
            wpSignupPbx.BackgroundImageLayout = ImageLayout.Center;
            wpSignupPbx.Dock = DockStyle.Right;
            wpSignupPbx.InitialImage = null;
            wpSignupPbx.Location = new Point(848, 0);
            wpSignupPbx.Margin = new Padding(0);
            wpSignupPbx.Name = "wpSignupPbx";
            wpSignupPbx.Size = new Size(480, 712);
            wpSignupPbx.TabIndex = 7;
            wpSignupPbx.TabStop = false;
            // 
            // usernamePanel
            // 
            usernamePanel.BackColor = SystemColors.InactiveCaption;
            usernamePanel.Location = new Point(146, 367);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.Size = new Size(534, 65);
            usernamePanel.TabIndex = 23;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = SystemColors.InactiveCaption;
            passwordPanel.Controls.Add(showPassBtn);
            passwordPanel.Location = new Point(146, 440);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(534, 65);
            passwordPanel.TabIndex = 24;
            // 
            // loginClose
            // 
            loginClose.BackColor = Color.Transparent;
            loginClose.BackgroundImage = Properties.Resources.loginClose3;
            loginClose.BackgroundImageLayout = ImageLayout.Center;
            loginClose.FlatAppearance.BorderSize = 0;
            loginClose.FlatStyle = FlatStyle.Flat;
            loginClose.ForeColor = Color.White;
            loginClose.Location = new Point(1291, 0);
            loginClose.Name = "loginClose";
            loginClose.Size = new Size(25, 25);
            loginClose.TabIndex = 25;
            loginClose.UseVisualStyleBackColor = false;
            loginClose.Click += loginClose_Click;
            // 
            // loginRestore
            // 
            loginRestore.BackColor = Color.Transparent;
            loginRestore.BackgroundImage = Properties.Resources.loginRestore1;
            loginRestore.BackgroundImageLayout = ImageLayout.Center;
            loginRestore.FlatAppearance.BorderSize = 0;
            loginRestore.FlatStyle = FlatStyle.Flat;
            loginRestore.ForeColor = Color.White;
            loginRestore.Location = new Point(1266, 0);
            loginRestore.Name = "loginRestore";
            loginRestore.Size = new Size(25, 25);
            loginRestore.TabIndex = 26;
            loginRestore.UseVisualStyleBackColor = false;
            loginRestore.Click += loginRestore_Click;
            // 
            // loginMinimize
            // 
            loginMinimize.BackColor = Color.Transparent;
            loginMinimize.BackgroundImage = Properties.Resources.loginMinimize;
            loginMinimize.BackgroundImageLayout = ImageLayout.Center;
            loginMinimize.FlatAppearance.BorderSize = 0;
            loginMinimize.FlatStyle = FlatStyle.Flat;
            loginMinimize.ForeColor = Color.White;
            loginMinimize.Location = new Point(1241, 0);
            loginMinimize.Name = "loginMinimize";
            loginMinimize.Size = new Size(25, 25);
            loginMinimize.TabIndex = 27;
            loginMinimize.UseVisualStyleBackColor = false;
            loginMinimize.Click += loginMinimize_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1328, 712);
            Controls.Add(loginMinimize);
            Controls.Add(loginRestore);
            Controls.Add(loginClose);
            Controls.Add(registerBtn);
            Controls.Add(signUp2Lbl);
            Controls.Add(signUp1Lbl);
            Controls.Add(googBtn);
            Controls.Add(fbBtn);
            Controls.Add(twtBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(usernameTxtBox);
            Controls.Add(label3);
            Controls.Add(wpSignupPbx);
            Controls.Add(usernamePanel);
            Controls.Add(passwordTxtBox);
            Controls.Add(passwordPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)showPassBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)wpSignupPbx).EndInit();
            passwordPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxtBox;
        private TextBox passwordTxtBox;
        private Button loginBtn;
        private Button registerBtn;
        private PictureBox showPassBtn;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label signUp2Lbl;
        private Label signUp1Lbl;
        private roundBtn twtBtn;
        private roundBtn fbBtn;
        private roundBtn googBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox wpSignupPbx;
        private Panel usernamePanel;
        private Panel passwordPanel;
        private Button loginClose;
        private Button loginMinimize;
        private Button loginRestore;
    }
}