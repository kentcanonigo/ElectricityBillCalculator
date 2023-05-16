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
            usernameTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            loginBtn = new Button();
            registerBtn = new Button();
            showPassBtn = new PictureBox();
            wpSignupPbx = new PictureBox();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            fbBtn = new Button();
            googBtn = new Button();
            twtBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            signup2Lbl = new Label();
            signUp1Lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wpSignupPbx).BeginInit();
            SuspendLayout();
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.BackColor = SystemColors.Window;
            usernameTxtBox.ForeColor = SystemColors.InactiveCaption;
            usernameTxtBox.Location = new Point(147, 393);
            usernameTxtBox.Multiline = true;
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(534, 65);
            usernameTxtBox.TabIndex = 0;
            usernameTxtBox.Text = "\r\nUsername";
            usernameTxtBox.Enter += usernameTxtBox_Enter;
            usernameTxtBox.Leave += usernameTxtBox_Leave;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.BackColor = SystemColors.Window;
            passwordTxtBox.ForeColor = SystemColors.InactiveCaption;
            passwordTxtBox.Location = new Point(146, 466);
            passwordTxtBox.Multiline = true;
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '•';
            passwordTxtBox.Size = new Size(534, 65);
            passwordTxtBox.TabIndex = 1;
            passwordTxtBox.Text = "\r\nPassword";
            passwordTxtBox.Enter += passwordTxtBox_Enter;
            passwordTxtBox.Leave += passwordTxtBox_Leave;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(281, 545);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(264, 61);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(985, 493);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(264, 61);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Sign Up";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // showPassBtn
            // 
            showPassBtn.BackColor = SystemColors.ControlLightLight;
            showPassBtn.Image = Properties.Resources.hidePass;
            showPassBtn.Location = new Point(623, 482);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(42, 33);
            showPassBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            showPassBtn.TabIndex = 6;
            showPassBtn.TabStop = false;
            showPassBtn.Click += showPassBtn_Click;
            // 
            // wpSignupPbx
            // 
            wpSignupPbx.BackgroundImage = Properties.Resources.wp4_safeimagekit1;
            wpSignupPbx.BackgroundImageLayout = ImageLayout.Center;
            wpSignupPbx.Location = new Point(865, -1);
            wpSignupPbx.Margin = new Padding(0);
            wpSignupPbx.Name = "wpSignupPbx";
            wpSignupPbx.Size = new Size(513, 750);
            wpSignupPbx.TabIndex = 7;
            wpSignupPbx.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(406, 367);
            label1.Name = "label1";
            label1.Size = new Size(28, 18);
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
            // fbBtn
            // 
            fbBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fbBtn.BackColor = SystemColors.ControlLightLight;
            fbBtn.BackgroundImage = Properties.Resources.fb;
            fbBtn.BackgroundImageLayout = ImageLayout.Center;
            fbBtn.FlatAppearance.BorderSize = 0;
            fbBtn.FlatStyle = FlatStyle.Flat;
            fbBtn.Location = new Point(306, 276);
            fbBtn.Margin = new Padding(3, 4, 3, 4);
            fbBtn.Name = "fbBtn";
            fbBtn.Size = new Size(71, 83);
            fbBtn.TabIndex = 9;
            fbBtn.UseVisualStyleBackColor = false;
            // 
            // googBtn
            // 
            googBtn.BackgroundImage = Properties.Resources.google;
            googBtn.BackgroundImageLayout = ImageLayout.Center;
            googBtn.Location = new Point(383, 276);
            googBtn.Margin = new Padding(3, 4, 3, 4);
            googBtn.Name = "googBtn";
            googBtn.Size = new Size(71, 83);
            googBtn.TabIndex = 10;
            googBtn.UseVisualStyleBackColor = true;
            // 
            // twtBtn
            // 
            twtBtn.BackgroundImage = Properties.Resources.twitter__1___1_;
            twtBtn.BackgroundImageLayout = ImageLayout.Center;
            twtBtn.Location = new Point(459, 276);
            twtBtn.Margin = new Padding(3, 4, 3, 4);
            twtBtn.Name = "twtBtn";
            twtBtn.Size = new Size(71, 83);
            twtBtn.TabIndex = 11;
            twtBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(281, 231);
            label2.Name = "label2";
            label2.Size = new Size(288, 31);
            label2.TabIndex = 12;
            label2.Text = "Login using social networks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 127);
            label3.Name = "label3";
            label3.Size = new Size(816, 105);
            label3.TabIndex = 13;
            label3.Text = "Login to Your Account";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(59, 376);
            label4.Name = "label4";
            label4.Size = new Size(345, 3);
            label4.TabIndex = 14;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(432, 376);
            label5.Name = "label5";
            label5.Size = new Size(345, 3);
            label5.TabIndex = 15;
            // 
            // signup2Lbl
            // 
            signup2Lbl.AutoSize = true;
            signup2Lbl.BackColor = Color.Transparent;
            signup2Lbl.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point);
            signup2Lbl.Location = new Point(925, 391);
            signup2Lbl.Name = "signup2Lbl";
            signup2Lbl.Size = new Size(369, 78);
            signup2Lbl.TabIndex = 16;
            signup2Lbl.Text = "Sign up and discover a great\r\namount of opportunities!\r\n";
            signup2Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signUp1Lbl
            // 
            signUp1Lbl.AutoSize = true;
            signUp1Lbl.BackColor = SystemColors.Control;
            signUp1Lbl.Font = new Font("Sylfaen", 36F, FontStyle.Regular, GraphicsUnit.Point);
            signUp1Lbl.Location = new Point(957, 281);
            signUp1Lbl.Name = "signUp1Lbl";
            signUp1Lbl.Size = new Size(315, 79);
            signUp1Lbl.TabIndex = 17;
            signUp1Lbl.Text = "New Here?";
            signUp1Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 712);
            Controls.Add(signUp1Lbl);
            Controls.Add(signup2Lbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(twtBtn);
            Controls.Add(googBtn);
            Controls.Add(fbBtn);
            Controls.Add(label1);
            Controls.Add(showPassBtn);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxtBox);
            Controls.Add(usernameTxtBox);
            Controls.Add(label3);
            Controls.Add(wpSignupPbx);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)showPassBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)wpSignupPbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxtBox;
        private TextBox passwordTxtBox;
        private Button loginBtn;
        private Button registerBtn;
        private PictureBox showPassBtn;
        private PictureBox wpSignupPbx;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button fbBtn;
        private Button googBtn;
        private Button twtBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label signup2Lbl;
        private Label signUp1Lbl;
    }
}