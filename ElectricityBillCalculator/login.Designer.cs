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
            loginKent = new roundBtn();
            loginRex = new roundBtn();
            loginRK = new roundBtn();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            wpSignupPbx = new PictureBox();
            usernamePanel = new Panel();
            passwordPanel = new Panel();
            loginClose = new Button();
            loginMinimize = new Button();
            label6 = new Label();
            forgotPassBtn = new Label();
            rememberCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wpSignupPbx).BeginInit();
            passwordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTxtBox.BackColor = SystemColors.InactiveCaption;
            usernameTxtBox.BorderStyle = BorderStyle.None;
            usernameTxtBox.Cursor = Cursors.IBeam;
            usernameTxtBox.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTxtBox.Location = new Point(155, 369);
            usernameTxtBox.Multiline = true;
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.PlaceholderText = "Username";
            usernameTxtBox.Size = new Size(457, 34);
            usernameTxtBox.TabIndex = 0;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTxtBox.BackColor = SystemColors.InactiveCaption;
            passwordTxtBox.BorderStyle = BorderStyle.None;
            passwordTxtBox.Cursor = Cursors.IBeam;
            passwordTxtBox.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxtBox.Location = new Point(155, 442);
            passwordTxtBox.Multiline = true;
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '•';
            passwordTxtBox.PlaceholderText = "Password";
            passwordTxtBox.Size = new Size(457, 34);
            passwordTxtBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginBtn.AutoSize = true;
            loginBtn.BackColor = Color.PowderBlue;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Moon", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(281, 526);
            loginBtn.Margin = new Padding(0);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(282, 80);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            registerBtn.AutoSize = true;
            registerBtn.BackColor = Color.PowderBlue;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Moon", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(958, 431);
            registerBtn.Margin = new Padding(0);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(282, 80);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Sign Up";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // showPassBtn
            // 
            showPassBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showPassBtn.BackColor = SystemColors.InactiveCaption;
            showPassBtn.Cursor = Cursors.Hand;
            showPassBtn.Image = Properties.Resources.hidePass;
            showPassBtn.Location = new Point(466, 4);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(68, 57);
            showPassBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            showPassBtn.TabIndex = 6;
            showPassBtn.TabStop = false;
            showPassBtn.Click += showPassBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Moon", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(408, 327);
            label1.Name = "label1";
            label1.Size = new Size(20, 11);
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
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Avoda", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(239, 217);
            label2.Name = "label2";
            label2.Size = new Size(357, 34);
            label2.TabIndex = 12;
            label2.Text = "and discover the power of our app";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("ArterioNonCommercial", 39.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 160);
            label3.Name = "label3";
            label3.Size = new Size(706, 53);
            label3.TabIndex = 13;
            label3.Text = "Login to Your Account";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(63, 333);
            label4.Name = "label4";
            label4.Size = new Size(345, 3);
            label4.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(433, 333);
            label5.Name = "label5";
            label5.Size = new Size(345, 3);
            label5.TabIndex = 15;
            // 
            // signUp2Lbl
            // 
            signUp2Lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUp2Lbl.AutoSize = true;
            signUp2Lbl.BackColor = Color.Transparent;
            signUp2Lbl.Cursor = Cursors.IBeam;
            signUp2Lbl.Font = new Font("Geomanist", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            signUp2Lbl.ForeColor = Color.White;
            signUp2Lbl.Location = new Point(924, 353);
            signUp2Lbl.Name = "signUp2Lbl";
            signUp2Lbl.Size = new Size(356, 66);
            signUp2Lbl.TabIndex = 16;
            signUp2Lbl.Text = "Sign up and discover a great\r\namount of opportunities!\r\n";
            signUp2Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signUp1Lbl
            // 
            signUp1Lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUp1Lbl.AutoSize = true;
            signUp1Lbl.BackColor = Color.Transparent;
            signUp1Lbl.CausesValidation = false;
            signUp1Lbl.Cursor = Cursors.IBeam;
            signUp1Lbl.FlatStyle = FlatStyle.Flat;
            signUp1Lbl.Font = new Font("Moon", 48F, FontStyle.Bold, GraphicsUnit.Point);
            signUp1Lbl.ForeColor = Color.White;
            signUp1Lbl.Location = new Point(895, 277);
            signUp1Lbl.Name = "signUp1Lbl";
            signUp1Lbl.Size = new Size(397, 67);
            signUp1Lbl.TabIndex = 17;
            signUp1Lbl.Text = "New Here?";
            signUp1Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginKent
            // 
            loginKent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginKent.AutoSize = true;
            loginKent.BackColor = SystemColors.Control;
            loginKent.BackgroundImage = Properties.Resources.loginKent1;
            loginKent.BackgroundImageLayout = ImageLayout.Center;
            loginKent.Cursor = Cursors.Hand;
            loginKent.FlatAppearance.BorderSize = 0;
            loginKent.FlatStyle = FlatStyle.Flat;
            loginKent.Location = new Point(462, 259);
            loginKent.Name = "loginKent";
            loginKent.Size = new Size(62, 62);
            loginKent.TabIndex = 20;
            loginKent.UseVisualStyleBackColor = false;
            loginKent.Click += loginKent_Click;
            // 
            // loginRex
            // 
            loginRex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginRex.AutoSize = true;
            loginRex.BackColor = SystemColors.Control;
            loginRex.BackgroundImage = Properties.Resources.loginRex1;
            loginRex.BackgroundImageLayout = ImageLayout.Center;
            loginRex.Cursor = Cursors.Hand;
            loginRex.FlatAppearance.BorderSize = 0;
            loginRex.FlatStyle = FlatStyle.Flat;
            loginRex.Location = new Point(309, 259);
            loginRex.Name = "loginRex";
            loginRex.Size = new Size(62, 62);
            loginRex.TabIndex = 21;
            loginRex.UseVisualStyleBackColor = false;
            loginRex.Click += loginRex_Click;
            // 
            // loginRK
            // 
            loginRK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginRK.AutoSize = true;
            loginRK.BackColor = SystemColors.Control;
            loginRK.BackgroundImage = Properties.Resources.loginLogo1;
            loginRK.BackgroundImageLayout = ImageLayout.Center;
            loginRK.Cursor = Cursors.Hand;
            loginRK.FlatAppearance.BorderSize = 0;
            loginRK.FlatStyle = FlatStyle.Flat;
            loginRK.Location = new Point(386, 259);
            loginRK.Name = "loginRK";
            loginRK.Size = new Size(62, 62);
            loginRK.TabIndex = 22;
            loginRK.UseVisualStyleBackColor = false;
            loginRK.Click += loginRK_Click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 20;
            bunifuElipse1.TargetControl = this;
            // 
            // wpSignupPbx
            // 
            wpSignupPbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wpSignupPbx.BackColor = Color.Black;
            wpSignupPbx.BackgroundImage = Properties.Resources.wpSignUpBg;
            wpSignupPbx.BackgroundImageLayout = ImageLayout.Center;
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
            usernamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernamePanel.BackColor = SystemColors.InactiveCaption;
            usernamePanel.Location = new Point(146, 353);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.Size = new Size(534, 65);
            usernamePanel.TabIndex = 23;
            // 
            // passwordPanel
            // 
            passwordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordPanel.BackColor = SystemColors.InactiveCaption;
            passwordPanel.Controls.Add(showPassBtn);
            passwordPanel.Location = new Point(146, 426);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(534, 65);
            passwordPanel.TabIndex = 24;
            // 
            // loginClose
            // 
            loginClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // loginMinimize
            // 
            loginMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginMinimize.BackColor = Color.Transparent;
            loginMinimize.BackgroundImage = Properties.Resources.loginMinimize;
            loginMinimize.BackgroundImageLayout = ImageLayout.Center;
            loginMinimize.FlatAppearance.BorderSize = 0;
            loginMinimize.FlatStyle = FlatStyle.Flat;
            loginMinimize.ForeColor = Color.White;
            loginMinimize.Location = new Point(1265, 0);
            loginMinimize.Name = "loginMinimize";
            loginMinimize.Size = new Size(25, 25);
            loginMinimize.TabIndex = 27;
            loginMinimize.UseVisualStyleBackColor = false;
            loginMinimize.Click += loginMinimize_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Image = Properties.Resources.iconEBC;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(10, 10);
            label6.Name = "label6";
            label6.Size = new Size(180, 15);
            label6.TabIndex = 28;
            label6.Text = "       RK - Electricity Bill Calculator";
            // 
            // forgotPassBtn
            // 
            forgotPassBtn.AutoSize = true;
            forgotPassBtn.Cursor = Cursors.Hand;
            forgotPassBtn.FlatStyle = FlatStyle.Flat;
            forgotPassBtn.Font = new Font("Geomanist", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            forgotPassBtn.Location = new Point(262, 498);
            forgotPassBtn.Name = "forgotPassBtn";
            forgotPassBtn.Size = new Size(121, 17);
            forgotPassBtn.TabIndex = 29;
            forgotPassBtn.Text = "Forgot password?";
            forgotPassBtn.Click += forgotPassBtn_Click;
            // 
            // rememberCheckBox
            // 
            rememberCheckBox.AutoSize = true;
            rememberCheckBox.Cursor = Cursors.Hand;
            rememberCheckBox.FlatAppearance.BorderSize = 0;
            rememberCheckBox.FlatStyle = FlatStyle.Flat;
            rememberCheckBox.Font = new Font("Geomanist", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            rememberCheckBox.ForeColor = Color.Blue;
            rememberCheckBox.Location = new Point(474, 496);
            rememberCheckBox.Name = "rememberCheckBox";
            rememberCheckBox.Size = new Size(117, 21);
            rememberCheckBox.TabIndex = 30;
            rememberCheckBox.Text = "Remember me";
            rememberCheckBox.TextAlign = ContentAlignment.TopCenter;
            rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            ClientSize = new Size(1328, 712);
            Controls.Add(rememberCheckBox);
            Controls.Add(forgotPassBtn);
            Controls.Add(label6);
            Controls.Add(loginMinimize);
            Controls.Add(loginClose);
            Controls.Add(registerBtn);
            Controls.Add(signUp2Lbl);
            Controls.Add(signUp1Lbl);
            Controls.Add(loginRK);
            Controls.Add(loginRex);
            Controls.Add(loginKent);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private roundBtn loginKent;
        private roundBtn loginRex;
        private roundBtn loginRK;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox wpSignupPbx;
        private Panel usernamePanel;
        private Panel passwordPanel;
        private Button loginClose;
        private Button loginMinimize;
        private Label label6;
        private CheckBox rememberCheckBox;
        private Label forgotPassBtn;
    }
}