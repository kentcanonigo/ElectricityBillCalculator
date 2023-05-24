namespace ElectricityBillCalculator
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            regConfPassShowBtn = new PictureBox();
            regConfPassTbx = new TextBox();
            regConfPassPanel = new Panel();
            regPassTbx = new TextBox();
            regPassPanel = new Panel();
            regPassShowBtn = new PictureBox();
            regUserTbx = new TextBox();
            regUserPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            regMailPanel = new Panel();
            regMailTbx = new TextBox();
            regInfoPanel = new Panel();
            passwordCheckerBtn = new roundBtn();
            generateLengthCbx = new ComboBox();
            generatePassBtn = new Label();
            loginLabel = new Label();
            label3 = new Label();
            signupBtn = new Button();
            label6 = new Label();
            pwCheckerTooltip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)regConfPassShowBtn).BeginInit();
            regConfPassPanel.SuspendLayout();
            regPassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)regPassShowBtn).BeginInit();
            regInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // regConfPassShowBtn
            // 
            regConfPassShowBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regConfPassShowBtn.BackColor = Color.White;
            regConfPassShowBtn.Cursor = Cursors.Hand;
            regConfPassShowBtn.Image = Properties.Resources.hidePass;
            regConfPassShowBtn.Location = new Point(259, 0);
            regConfPassShowBtn.Margin = new Padding(3, 2, 3, 2);
            regConfPassShowBtn.Name = "regConfPassShowBtn";
            regConfPassShowBtn.Size = new Size(59, 50);
            regConfPassShowBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            regConfPassShowBtn.TabIndex = 6;
            regConfPassShowBtn.TabStop = false;
            regConfPassShowBtn.Click += regConfPassShowBtn_Click;
            // 
            // regConfPassTbx
            // 
            regConfPassTbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regConfPassTbx.BackColor = Color.White;
            regConfPassTbx.BorderStyle = BorderStyle.None;
            regConfPassTbx.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            regConfPassTbx.Location = new Point(56, 345);
            regConfPassTbx.Margin = new Padding(3, 2, 3, 2);
            regConfPassTbx.Multiline = true;
            regConfPassTbx.Name = "regConfPassTbx";
            regConfPassTbx.PasswordChar = '•';
            regConfPassTbx.PlaceholderText = "Confirm Password";
            regConfPassTbx.Size = new Size(245, 32);
            regConfPassTbx.TabIndex = 5;
            // 
            // regConfPassPanel
            // 
            regConfPassPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regConfPassPanel.BackColor = Color.White;
            regConfPassPanel.Controls.Add(regConfPassShowBtn);
            regConfPassPanel.Location = new Point(47, 336);
            regConfPassPanel.Margin = new Padding(3, 2, 3, 2);
            regConfPassPanel.Name = "regConfPassPanel";
            regConfPassPanel.Size = new Size(318, 50);
            regConfPassPanel.TabIndex = 28;
            // 
            // regPassTbx
            // 
            regPassTbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regPassTbx.BackColor = Color.White;
            regPassTbx.BorderStyle = BorderStyle.None;
            regPassTbx.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            regPassTbx.ForeColor = SystemColors.WindowText;
            regPassTbx.Location = new Point(56, 262);
            regPassTbx.Margin = new Padding(3, 2, 3, 2);
            regPassTbx.Multiline = true;
            regPassTbx.Name = "regPassTbx";
            regPassTbx.PasswordChar = '•';
            regPassTbx.PlaceholderText = "Password";
            regPassTbx.Size = new Size(245, 32);
            regPassTbx.TabIndex = 2;
            regPassTbx.KeyDown += regPassTbx_KeyDown;
            // 
            // regPassPanel
            // 
            regPassPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regPassPanel.BackColor = Color.White;
            regPassPanel.Controls.Add(regPassShowBtn);
            regPassPanel.Location = new Point(47, 253);
            regPassPanel.Margin = new Padding(3, 2, 3, 2);
            regPassPanel.Name = "regPassPanel";
            regPassPanel.Size = new Size(318, 50);
            regPassPanel.TabIndex = 32;
            // 
            // regPassShowBtn
            // 
            regPassShowBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regPassShowBtn.BackColor = Color.White;
            regPassShowBtn.Cursor = Cursors.Hand;
            regPassShowBtn.Image = Properties.Resources.hidePass;
            regPassShowBtn.Location = new Point(259, 0);
            regPassShowBtn.Margin = new Padding(3, 2, 3, 2);
            regPassShowBtn.Name = "regPassShowBtn";
            regPassShowBtn.Size = new Size(59, 51);
            regPassShowBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            regPassShowBtn.TabIndex = 7;
            regPassShowBtn.TabStop = false;
            regPassShowBtn.Click += regPassShowBtn_Click;
            // 
            // regUserTbx
            // 
            regUserTbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regUserTbx.BackColor = Color.White;
            regUserTbx.BorderStyle = BorderStyle.None;
            regUserTbx.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            regUserTbx.ForeColor = SystemColors.WindowText;
            regUserTbx.Location = new Point(56, 151);
            regUserTbx.Margin = new Padding(3, 2, 3, 2);
            regUserTbx.Multiline = true;
            regUserTbx.Name = "regUserTbx";
            regUserTbx.PlaceholderText = "Username";
            regUserTbx.Size = new Size(292, 32);
            regUserTbx.TabIndex = 0;
            // 
            // regUserPanel
            // 
            regUserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regUserPanel.BackColor = Color.White;
            regUserPanel.Location = new Point(47, 142);
            regUserPanel.Margin = new Padding(3, 2, 3, 2);
            regUserPanel.Name = "regUserPanel";
            regUserPanel.Size = new Size(318, 50);
            regUserPanel.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Moon", 40.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 45);
            label1.Name = "label1";
            label1.Size = new Size(238, 56);
            label1.TabIndex = 37;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Geomanist", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(120, 98);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 38;
            label2.Text = "Create a new account";
            // 
            // regMailPanel
            // 
            regMailPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regMailPanel.BackColor = Color.White;
            regMailPanel.Location = new Point(47, 198);
            regMailPanel.Margin = new Padding(3, 2, 3, 2);
            regMailPanel.Name = "regMailPanel";
            regMailPanel.Size = new Size(318, 50);
            regMailPanel.TabIndex = 30;
            // 
            // regMailTbx
            // 
            regMailTbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regMailTbx.BackColor = Color.White;
            regMailTbx.BorderStyle = BorderStyle.None;
            regMailTbx.Font = new Font("Geomanist", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            regMailTbx.Location = new Point(56, 208);
            regMailTbx.Margin = new Padding(3, 2, 3, 2);
            regMailTbx.Multiline = true;
            regMailTbx.Name = "regMailTbx";
            regMailTbx.PlaceholderText = "Email";
            regMailTbx.Size = new Size(292, 32);
            regMailTbx.TabIndex = 1;
            // 
            // regInfoPanel
            // 
            regInfoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            regInfoPanel.BackColor = Color.PowderBlue;
            regInfoPanel.Controls.Add(passwordCheckerBtn);
            regInfoPanel.Controls.Add(generateLengthCbx);
            regInfoPanel.Controls.Add(generatePassBtn);
            regInfoPanel.Controls.Add(loginLabel);
            regInfoPanel.Controls.Add(label3);
            regInfoPanel.Location = new Point(34, 125);
            regInfoPanel.Margin = new Padding(3, 2, 3, 2);
            regInfoPanel.Name = "regInfoPanel";
            regInfoPanel.Size = new Size(343, 292);
            regInfoPanel.TabIndex = 39;
            // 
            // passwordCheckerBtn
            // 
            passwordCheckerBtn.BackColor = Color.White;
            passwordCheckerBtn.FlatAppearance.BorderSize = 0;
            passwordCheckerBtn.FlatStyle = FlatStyle.Flat;
            passwordCheckerBtn.Location = new Point(19, 184);
            passwordCheckerBtn.Name = "passwordCheckerBtn";
            passwordCheckerBtn.Size = new Size(20, 20);
            passwordCheckerBtn.TabIndex = 42;
            passwordCheckerBtn.UseVisualStyleBackColor = false;
            passwordCheckerBtn.MouseHover += passwordCheckerBtn_MouseHover;
            // 
            // generateLengthCbx
            // 
            generateLengthCbx.BackColor = Color.PowderBlue;
            generateLengthCbx.Cursor = Cursors.Hand;
            generateLengthCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            generateLengthCbx.FlatStyle = FlatStyle.Flat;
            generateLengthCbx.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            generateLengthCbx.ForeColor = Color.Black;
            generateLengthCbx.FormattingEnabled = true;
            generateLengthCbx.Items.AddRange(new object[] { "8 Char", "10 Char", "12 Char" });
            generateLengthCbx.Location = new Point(237, 183);
            generateLengthCbx.Margin = new Padding(3, 2, 3, 2);
            generateLengthCbx.Name = "generateLengthCbx";
            generateLengthCbx.Size = new Size(87, 23);
            generateLengthCbx.TabIndex = 4;
            // 
            // generatePassBtn
            // 
            generatePassBtn.AutoSize = true;
            generatePassBtn.Cursor = Cursors.Hand;
            generatePassBtn.FlatStyle = FlatStyle.Flat;
            generatePassBtn.Font = new Font("Geomanist", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            generatePassBtn.ForeColor = Color.Blue;
            generatePassBtn.Location = new Point(39, 185);
            generatePassBtn.Name = "generatePassBtn";
            generatePassBtn.Size = new Size(195, 19);
            generatePassBtn.TabIndex = 3;
            generatePassBtn.Text = "Generate Random Password";
            generatePassBtn.TextAlign = ContentAlignment.MiddleCenter;
            generatePassBtn.Click += generatePassBtn_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Cursor = Cursors.Hand;
            loginLabel.FlatStyle = FlatStyle.Flat;
            loginLabel.Font = new Font("Geomanist", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.Blue;
            loginLabel.Location = new Point(216, 265);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(89, 19);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "Log in Now!";
            loginLabel.Click += loginLabel_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Geomanist", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 265);
            label3.Name = "label3";
            label3.Size = new Size(179, 19);
            label3.TabIndex = 0;
            label3.Text = "Already have an account?";
            // 
            // signupBtn
            // 
            signupBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.Font = new Font("Moon", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            signupBtn.Location = new Point(34, 421);
            signupBtn.Margin = new Padding(3, 2, 3, 2);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(343, 47);
            signupBtn.TabIndex = 7;
            signupBtn.Text = "Sign up";
            signupBtn.UseVisualStyleBackColor = true;
            signupBtn.Click += singupBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Image = Properties.Resources.iconEBC;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(15, 15);
            label6.Name = "label6";
            label6.Size = new Size(174, 15);
            label6.TabIndex = 41;
            label6.Text = "     RK - Electricity Bill Calculator";
            // 
            // pwCheckerTooltip
            // 
            pwCheckerTooltip.AutoPopDelay = 5000;
            pwCheckerTooltip.InitialDelay = 50;
            pwCheckerTooltip.IsBalloon = true;
            pwCheckerTooltip.ReshowDelay = 50;
            pwCheckerTooltip.ToolTipIcon = ToolTipIcon.Info;
            pwCheckerTooltip.ToolTipTitle = "Password Strength";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.wpSignUpBg;
            ClientSize = new Size(404, 499);
            Controls.Add(label6);
            Controls.Add(signupBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(regUserTbx);
            Controls.Add(regUserPanel);
            Controls.Add(regMailTbx);
            Controls.Add(regMailPanel);
            Controls.Add(regConfPassTbx);
            Controls.Add(regConfPassPanel);
            Controls.Add(regPassTbx);
            Controls.Add(regPassPanel);
            Controls.Add(regInfoPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)regConfPassShowBtn).EndInit();
            regConfPassPanel.ResumeLayout(false);
            regPassPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)regPassShowBtn).EndInit();
            regInfoPanel.ResumeLayout(false);
            regInfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox regConfPassShowBtn;
        private TextBox regConfPassTbx;
        private Panel regConfPassPanel;
        private TextBox regPassTbx;
        private Panel regPassPanel;
        private TextBox regUserTbx;
        private Panel regUserPanel;
        private Label label1;
        private PictureBox regPassShowBtn;
        private Label label2;
        private Panel regMailPanel;
        private TextBox regMailTbx;
        private Panel regInfoPanel;
        private Label label3;
        private Button signupBtn;
        private Label loginLabel;
        private Label label6;
        private Label generatePassBtn;
        private ComboBox generateLengthCbx;
        private roundBtn passwordCheckerBtn;
        private ToolTip pwCheckerTooltip;
    }
}