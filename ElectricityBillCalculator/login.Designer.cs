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
            usernameLbl = new Label();
            passwordLbl = new Label();
            loginBtn = new Button();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(276, 208);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(283, 27);
            usernameTxtBox.TabIndex = 0;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(275, 258);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(285, 27);
            passwordTxtBox.TabIndex = 1;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Location = new Point(180, 215);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(82, 20);
            usernameLbl.TabIndex = 2;
            usernameLbl.Text = "Username: ";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(180, 262);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(77, 20);
            passwordLbl.TabIndex = 3;
            passwordLbl.Text = "Password: ";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(276, 304);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(125, 37);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(407, 307);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(152, 34);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordLbl);
            Controls.Add(usernameLbl);
            Controls.Add(passwordTxtBox);
            Controls.Add(usernameTxtBox);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxtBox;
        private TextBox passwordTxtBox;
        private Label usernameLbl;
        private Label passwordLbl;
        private Button loginBtn;
        private Button registerBtn;
    }
}