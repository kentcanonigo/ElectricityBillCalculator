namespace ElectricityBillCalculator
{
    partial class Form1
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
            titleLabel = new Label();
            applianceList = new ListBox();
            newButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(0, 10, 0, 0);
            titleLabel.Size = new Size(506, 62);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Electricity Bill Calculator";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // applianceList
            // 
            applianceList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            applianceList.FormattingEnabled = true;
            applianceList.ItemHeight = 21;
            applianceList.Location = new Point(12, 65);
            applianceList.Name = "applianceList";
            applianceList.Size = new Size(221, 424);
            applianceList.TabIndex = 1;
            applianceList.SelectedIndexChanged += applianceList_SelectedIndexChanged;
            applianceList.SelectedValueChanged += applianceList_SelectedValueChanged;
            // 
            // newButton
            // 
            newButton.BackColor = Color.LemonChiffon;
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.System;
            newButton.Location = new Point(12, 495);
            newButton.Name = "newButton";
            newButton.Size = new Size(103, 31);
            newButton.TabIndex = 2;
            newButton.Text = "New...";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Coral;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.System;
            deleteButton.Location = new Point(121, 495);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 31);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.ButtonFace;
            editButton.Cursor = Cursors.Hand;
            editButton.Enabled = false;
            editButton.FlatStyle = FlatStyle.System;
            editButton.Location = new Point(3, 133);
            editButton.Name = "editButton";
            editButton.Size = new Size(64, 31);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // panel1
            // 
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
            panel1.Location = new Point(239, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 424);
            panel1.TabIndex = 5;
            // 
            // yearlyBillTextbox
            // 
            yearlyBillTextbox.Enabled = false;
            yearlyBillTextbox.Location = new Point(64, 380);
            yearlyBillTextbox.MaxLength = 2;
            yearlyBillTextbox.Name = "yearlyBillTextbox";
            yearlyBillTextbox.Size = new Size(129, 23);
            yearlyBillTextbox.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(84, 356);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 17;
            label8.Text = "Yearly bill:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 288);
            label7.Name = "label7";
            label7.Size = new Size(191, 21);
            label7.TabIndex = 16;
            label7.Text = "Your average monthly bill:";
            // 
            // monthlyBillTextbox
            // 
            monthlyBillTextbox.Enabled = false;
            monthlyBillTextbox.Location = new Point(64, 312);
            monthlyBillTextbox.MaxLength = 2;
            monthlyBillTextbox.Name = "monthlyBillTextbox";
            monthlyBillTextbox.Size = new Size(129, 23);
            monthlyBillTextbox.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(84, 257);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 14;
            label6.Text = "Summary";
            // 
            // hrsPerDayTextbox
            // 
            hrsPerDayTextbox.Enabled = false;
            hrsPerDayTextbox.Location = new Point(123, 96);
            hrsPerDayTextbox.MaxLength = 2;
            hrsPerDayTextbox.Name = "hrsPerDayTextbox";
            hrsPerDayTextbox.Size = new Size(129, 23);
            hrsPerDayTextbox.TabIndex = 13;
            hrsPerDayTextbox.KeyPress += hrsPerDayTextbox_KeyPress;
            // 
            // wattageTextbox
            // 
            wattageTextbox.Enabled = false;
            wattageTextbox.Location = new Point(63, 67);
            wattageTextbox.MaxLength = 5;
            wattageTextbox.Name = "wattageTextbox";
            wattageTextbox.Size = new Size(189, 23);
            wattageTextbox.TabIndex = 12;
            wattageTextbox.TextChanged += wattageTextbox_TextChanged;
            wattageTextbox.KeyPress += wattageTextbox_KeyPress;
            // 
            // kwhRateTextbox
            // 
            kwhRateTextbox.Enabled = false;
            kwhRateTextbox.Location = new Point(69, 185);
            kwhRateTextbox.MaxLength = 6;
            kwhRateTextbox.Name = "kwhRateTextbox";
            kwhRateTextbox.Size = new Size(183, 23);
            kwhRateTextbox.TabIndex = 11;
            kwhRateTextbox.Text = "14.28";
            kwhRateTextbox.KeyPress += kwhRateTextbox_KeyPress;
            // 
            // customRateCheckbox
            // 
            customRateCheckbox.AutoSize = true;
            customRateCheckbox.Location = new Point(69, 214);
            customRateCheckbox.Name = "customRateCheckbox";
            customRateCheckbox.Size = new Size(68, 19);
            customRateCheckbox.TabIndex = 10;
            customRateCheckbox.Text = "Custom";
            customRateCheckbox.UseVisualStyleBackColor = true;
            customRateCheckbox.CheckedChanged += customRateCheckbox_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 188);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 9;
            label5.Text = "kWh Rate:";
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ButtonFace;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Enabled = false;
            saveButton.FlatStyle = FlatStyle.System;
            saveButton.Location = new Point(69, 133);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(48, 31);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 99);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 6;
            label4.Text = "Hours Used Per Day:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 70);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Wattage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // appNameTextbox
            // 
            appNameTextbox.Enabled = false;
            appNameTextbox.Location = new Point(51, 38);
            appNameTextbox.MaxLength = 20;
            appNameTextbox.Name = "appNameTextbox";
            appNameTextbox.Size = new Size(201, 23);
            appNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 30);
            label2.TabIndex = 0;
            label2.Text = "Appliance Info";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // aboutButton
            // 
            aboutButton.BackColor = Color.PeachPuff;
            aboutButton.Cursor = Cursors.Hand;
            aboutButton.FlatStyle = FlatStyle.System;
            aboutButton.Location = new Point(383, 495);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(111, 31);
            aboutButton.TabIndex = 8;
            aboutButton.Text = "About..";
            aboutButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 537);
            Controls.Add(aboutButton);
            Controls.Add(panel1);
            Controls.Add(deleteButton);
            Controls.Add(newButton);
            Controls.Add(applianceList);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = ".";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private ListBox applianceList;
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
    }
}