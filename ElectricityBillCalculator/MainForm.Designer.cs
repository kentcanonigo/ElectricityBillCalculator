namespace ElectricityBillCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            titleLabel = new Label();
            applianceList = new ListBox();
            newButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            panel1 = new Panel();
            helpBtn = new roundBtn();
            label10 = new Label();
            daysUsedTextbox = new TextBox();
            label11 = new Label();
            calculateButton = new Button();
            label9 = new Label();
            appCostTextbox = new TextBox();
            yearlyBillTextbox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            monthlyBillTextbox = new TextBox();
            label6 = new Label();
            hrsPerDayTextbox = new TextBox();
            wattageTextbox = new TextBox();
            kwhRateTextbox = new TextBox();
            customRateCheckbox = new CheckBox();
            label5 = new Label();
            saveButton = new Button();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            appNameTextbox = new TextBox();
            label2 = new Label();
            aboutButton = new Button();
            loginMinimize = new Button();
            loginRestore = new Button();
            loginClose = new Button();
            label12 = new Label();
            logoutBtn = new Button();
            appInfoToolTip = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("ArterioNonCommercial", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(-70, 34);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(0, 10, 0, 0);
            titleLabel.Size = new Size(832, 75);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Electricity Bill Calculator";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // applianceList
            // 
            applianceList.BackColor = SystemColors.Control;
            applianceList.Font = new Font("Geomanist", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            applianceList.FormattingEnabled = true;
            applianceList.ItemHeight = 20;
            applianceList.Location = new Point(19, 100);
            applianceList.Name = "applianceList";
            applianceList.Size = new Size(221, 424);
            applianceList.TabIndex = 1;
            appInfoToolTip.SetToolTip(applianceList, "These are the appliances that\r\nyou are using.");
            applianceList.SelectedIndexChanged += applianceList_SelectedIndexChanged;
            applianceList.SelectedValueChanged += applianceList_SelectedValueChanged;
            // 
            // newButton
            // 
            newButton.BackColor = SystemColors.Control;
            newButton.Cursor = Cursors.Hand;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newButton.Location = new Point(19, 530);
            newButton.Name = "newButton";
            newButton.Size = new Size(103, 31);
            newButton.TabIndex = 2;
            newButton.Text = "New...";
            appInfoToolTip.SetToolTip(newButton, "Add a new appliance.");
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.Control;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(128, 530);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 31);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            appInfoToolTip.SetToolTip(deleteButton, "Click an appliance and delete.");
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.Window;
            editButton.Cursor = Cursors.Hand;
            editButton.Enabled = false;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editButton.Location = new Point(119, 162);
            editButton.Name = "editButton";
            editButton.Size = new Size(114, 31);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            appInfoToolTip.SetToolTip(editButton, "Click here to edit the data above.");
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(helpBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(daysUsedTextbox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(calculateButton);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(appCostTextbox);
            panel1.Controls.Add(yearlyBillTextbox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(monthlyBillTextbox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(hrsPerDayTextbox);
            panel1.Controls.Add(wattageTextbox);
            panel1.Controls.Add(kwhRateTextbox);
            panel1.Controls.Add(customRateCheckbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(appNameTextbox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(257, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 424);
            panel1.TabIndex = 5;
            // 
            // helpBtn
            // 
            helpBtn.BackgroundImage = Properties.Resources.helpBtn4;
            helpBtn.BackgroundImageLayout = ImageLayout.Center;
            helpBtn.FlatAppearance.BorderSize = 0;
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.Location = new Point(377, 5);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(25, 25);
            helpBtn.TabIndex = 24;
            appInfoToolTip.SetToolTip(helpBtn, "Need help? Just hover on the buttons for instructions.");
            helpBtn.UseVisualStyleBackColor = true;
            helpBtn.Click += helpBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(25, 130);
            label10.Name = "label10";
            label10.Size = new Size(67, 16);
            label10.TabIndex = 23;
            label10.Text = "Days used:";
            // 
            // daysUsedTextbox
            // 
            daysUsedTextbox.Enabled = false;
            daysUsedTextbox.Location = new Point(98, 126);
            daysUsedTextbox.MaxLength = 2;
            daysUsedTextbox.Name = "daysUsedTextbox";
            daysUsedTextbox.Size = new Size(287, 23);
            daysUsedTextbox.TabIndex = 14;
            appInfoToolTip.SetToolTip(daysUsedTextbox, "This is the number of days used by the appliance per month.");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(142, 213);
            label11.Name = "label11";
            label11.Size = new Size(19, 21);
            label11.TabIndex = 21;
            label11.Text = "₱";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.Window;
            calculateButton.Cursor = Cursors.Hand;
            calculateButton.FlatAppearance.BorderSize = 0;
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calculateButton.Location = new Point(148, 364);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(111, 31);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Calculate!";
            appInfoToolTip.SetToolTip(calculateButton, "Click this to calculate your electricity bill.");
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(82, 248);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 20;
            label9.Text = "Appliance Cost/day:";
            // 
            // appCostTextbox
            // 
            appCostTextbox.Enabled = false;
            appCostTextbox.Location = new Point(202, 245);
            appCostTextbox.MaxLength = 2;
            appCostTextbox.Name = "appCostTextbox";
            appCostTextbox.Size = new Size(129, 23);
            appCostTextbox.TabIndex = 19;
            appInfoToolTip.SetToolTip(appCostTextbox, "This is the total cost of the application used in the day.");
            // 
            // yearlyBillTextbox
            // 
            yearlyBillTextbox.Enabled = false;
            yearlyBillTextbox.Location = new Point(213, 334);
            yearlyBillTextbox.MaxLength = 2;
            yearlyBillTextbox.Name = "yearlyBillTextbox";
            yearlyBillTextbox.Size = new Size(129, 23);
            yearlyBillTextbox.TabIndex = 18;
            appInfoToolTip.SetToolTip(yearlyBillTextbox, "This is the total cost of the application used in the year.");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Geomanist", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(219, 310);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 17;
            label8.Text = "Total Yearly Bill:";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geomanist", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(63, 311);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 16;
            label7.Text = "Total Monthly Bill:";
            // 
            // monthlyBillTextbox
            // 
            monthlyBillTextbox.Enabled = false;
            monthlyBillTextbox.Location = new Point(63, 335);
            monthlyBillTextbox.MaxLength = 2;
            monthlyBillTextbox.Name = "monthlyBillTextbox";
            monthlyBillTextbox.Size = new Size(129, 23);
            monthlyBillTextbox.TabIndex = 15;
            appInfoToolTip.SetToolTip(monthlyBillTextbox, "This is the total cost of the application used in the month.");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Moon", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(161, 286);
            label6.Name = "label6";
            label6.Size = new Size(88, 16);
            label6.TabIndex = 14;
            label6.Text = "Summary";
            // 
            // hrsPerDayTextbox
            // 
            hrsPerDayTextbox.Enabled = false;
            hrsPerDayTextbox.Location = new Point(98, 96);
            hrsPerDayTextbox.MaxLength = 2;
            hrsPerDayTextbox.Name = "hrsPerDayTextbox";
            hrsPerDayTextbox.Size = new Size(287, 23);
            hrsPerDayTextbox.TabIndex = 13;
            appInfoToolTip.SetToolTip(hrsPerDayTextbox, "This is the number of hours used by the appliance per day.");
            hrsPerDayTextbox.KeyPress += hrsPerDayTextbox_KeyPress;
            // 
            // wattageTextbox
            // 
            wattageTextbox.Enabled = false;
            wattageTextbox.Location = new Point(98, 66);
            wattageTextbox.MaxLength = 5;
            wattageTextbox.Name = "wattageTextbox";
            wattageTextbox.Size = new Size(286, 23);
            wattageTextbox.TabIndex = 12;
            appInfoToolTip.SetToolTip(wattageTextbox, "This is the wattage of the Appliance.");
            wattageTextbox.TextChanged += wattageTextbox_TextChanged;
            wattageTextbox.KeyPress += wattageTextbox_KeyPress;
            // 
            // kwhRateTextbox
            // 
            kwhRateTextbox.Enabled = false;
            kwhRateTextbox.Location = new Point(161, 212);
            kwhRateTextbox.MaxLength = 6;
            kwhRateTextbox.Name = "kwhRateTextbox";
            kwhRateTextbox.Size = new Size(98, 23);
            kwhRateTextbox.TabIndex = 11;
            kwhRateTextbox.Text = "14.28";
            appInfoToolTip.SetToolTip(kwhRateTextbox, "This is the standard rate of Veco.");
            kwhRateTextbox.TextChanged += kwhRateTextbox_TextChanged;
            kwhRateTextbox.KeyPress += kwhRateTextbox_KeyPress;
            // 
            // customRateCheckbox
            // 
            customRateCheckbox.AutoSize = true;
            customRateCheckbox.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customRateCheckbox.Location = new Point(263, 214);
            customRateCheckbox.Name = "customRateCheckbox";
            customRateCheckbox.Size = new Size(67, 19);
            customRateCheckbox.TabIndex = 10;
            customRateCheckbox.Text = "Custom";
            appInfoToolTip.SetToolTip(customRateCheckbox, "Check this to adjust the kWh Rate.");
            customRateCheckbox.UseVisualStyleBackColor = true;
            customRateCheckbox.CheckedChanged += customRateCheckbox_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(82, 218);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 9;
            label5.Text = "kWh Rate:";
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.Window;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Enabled = false;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(239, 162);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(129, 31);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            appInfoToolTip.SetToolTip(saveButton, "Save the data");
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 100);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 6;
            label4.Text = "Hours/Day:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 70);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 4;
            label1.Text = "Wattage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 40);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // appNameTextbox
            // 
            appNameTextbox.Enabled = false;
            appNameTextbox.Location = new Point(98, 36);
            appNameTextbox.MaxLength = 20;
            appNameTextbox.Name = "appNameTextbox";
            appNameTextbox.Size = new Size(286, 23);
            appNameTextbox.TabIndex = 1;
            appInfoToolTip.SetToolTip(appNameTextbox, "This is the name of the Appliance.");
            // 
            // label2
            // 
            label2.Font = new Font("Moon", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(409, 30);
            label2.TabIndex = 0;
            label2.Text = "Appliance Info";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // aboutButton
            // 
            aboutButton.BackColor = SystemColors.Control;
            aboutButton.Cursor = Cursors.Hand;
            aboutButton.FlatAppearance.BorderSize = 0;
            aboutButton.FlatStyle = FlatStyle.Flat;
            aboutButton.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            aboutButton.Location = new Point(405, 530);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(111, 31);
            aboutButton.TabIndex = 8;
            aboutButton.Text = "About..";
            appInfoToolTip.SetToolTip(aboutButton, "Information about the developers.");
            aboutButton.UseVisualStyleBackColor = false;
            aboutButton.Click += aboutButton_Click;
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
            loginMinimize.Location = new Point(580, 9);
            loginMinimize.Name = "loginMinimize";
            loginMinimize.Size = new Size(25, 25);
            loginMinimize.TabIndex = 28;
            loginMinimize.UseVisualStyleBackColor = false;
            loginMinimize.Click += loginMinimize_Click;
            // 
            // loginRestore
            // 
            loginRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginRestore.BackColor = Color.Transparent;
            loginRestore.BackgroundImage = Properties.Resources.loginMaximize1;
            loginRestore.BackgroundImageLayout = ImageLayout.Center;
            loginRestore.FlatAppearance.BorderSize = 0;
            loginRestore.FlatStyle = FlatStyle.Flat;
            loginRestore.ForeColor = Color.White;
            loginRestore.Location = new Point(611, 9);
            loginRestore.Name = "loginRestore";
            loginRestore.Size = new Size(25, 25);
            loginRestore.TabIndex = 29;
            loginRestore.UseVisualStyleBackColor = false;
            loginRestore.Click += loginRestore_Click;
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
            loginClose.Location = new Point(641, 9);
            loginClose.Name = "loginClose";
            loginClose.Size = new Size(25, 25);
            loginClose.TabIndex = 30;
            loginClose.UseVisualStyleBackColor = false;
            loginClose.Click += loginClose_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Image = Properties.Resources.iconEBC;
            label12.ImageAlign = ContentAlignment.MiddleLeft;
            label12.Location = new Point(12, 9);
            label12.Name = "label12";
            label12.Size = new Size(183, 15);
            label12.TabIndex = 31;
            label12.Text = "        RK - Electricity Bill Calculator";
            // 
            // logoutBtn
            // 
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Font = new Font("Geomanist", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logoutBtn.Location = new Point(555, 569);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(111, 31);
            logoutBtn.TabIndex = 32;
            logoutBtn.Text = "Log Out";
            appInfoToolTip.SetToolTip(logoutBtn, "Go back to the log-in page.");
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // appInfoToolTip
            // 
            appInfoToolTip.IsBalloon = true;
            appInfoToolTip.ToolTipIcon = ToolTipIcon.Info;
            appInfoToolTip.ToolTipTitle = "Help";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(687, 616);
            Controls.Add(logoutBtn);
            Controls.Add(label12);
            Controls.Add(loginClose);
            Controls.Add(loginRestore);
            Controls.Add(loginMinimize);
            Controls.Add(aboutButton);
            Controls.Add(panel1);
            Controls.Add(deleteButton);
            Controls.Add(newButton);
            Controls.Add(applianceList);
            Controls.Add(titleLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RK - Electricity Bill Calculator";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        public ListBox applianceList;
        private Button newButton;
        private Button deleteButton;
        private Button editButton;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox appNameTextbox;
        private Label label1;
        private Button saveButton;
        private Button aboutButton;
        private CheckBox customRateCheckbox;
        private Label label5;
        private Label label4;
        private TextBox kwhRateTextbox;
        private TextBox hrsPerDayTextbox;
        private TextBox wattageTextbox;
        private Label label7;
        private TextBox monthlyBillTextbox;
        private Label label6;
        private Label label8;
        private TextBox yearlyBillTextbox;
        private Label label9;
        private TextBox appCostTextbox;
        private Button calculateButton;
        private Label label11;
        private Button loginMinimize;
        private Button loginRestore;
        private Button loginClose;
        private Label label12;
        private Button logoutBtn;
        private Label label10;
        private TextBox daysUsedTextbox;
        private roundBtn helpBtn;
        private ToolTip appInfoToolTip;
    }
}