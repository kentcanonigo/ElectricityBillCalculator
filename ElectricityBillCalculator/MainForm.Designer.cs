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
            label11 = new Label();
            label10 = new Label();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(0, 13, 0, 0);
            titleLabel.Size = new Size(578, 83);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Electricity Bill Calculator";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // applianceList
            // 
            applianceList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            applianceList.FormattingEnabled = true;
            applianceList.ItemHeight = 28;
            applianceList.Location = new Point(14, 87);
            applianceList.Margin = new Padding(3, 4, 3, 4);
            applianceList.Name = "applianceList";
            applianceList.Size = new Size(252, 564);
            applianceList.TabIndex = 1;
            applianceList.SelectedIndexChanged += applianceList_SelectedIndexChanged;
            applianceList.SelectedValueChanged += applianceList_SelectedValueChanged;
            // 
            // newButton
            // 
            newButton.BackColor = Color.LemonChiffon;
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.System;
            newButton.Location = new Point(14, 660);
            newButton.Margin = new Padding(3, 4, 3, 4);
            newButton.Name = "newButton";
            newButton.Size = new Size(118, 41);
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
            deleteButton.Location = new Point(138, 660);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(128, 41);
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
            editButton.Location = new Point(3, 167);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(130, 41);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
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
            panel1.Location = new Point(273, 87);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 565);
            panel1.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(72, 217);
            label11.Name = "label11";
            label11.Size = new Size(24, 28);
            label11.TabIndex = 21;
            label11.Text = "₱";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(72, 213);
            label10.Name = "label10";
            label10.Size = new Size(24, 28);
            label10.TabIndex = 21;
            label10.Text = "₱";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.PeachPuff;
            calculateButton.Cursor = Cursors.Hand;
            calculateButton.FlatStyle = FlatStyle.System;
            calculateButton.Location = new Point(79, 508);
            calculateButton.Margin = new Padding(3, 4, 3, 4);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(127, 41);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Calculate!";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 264);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 20;
            label9.Text = "Appliance Cost/day:";
            // 
            // appCostTextbox
            // 
            appCostTextbox.Enabled = false;
            appCostTextbox.Location = new Point(141, 260);
            appCostTextbox.Margin = new Padding(3, 4, 3, 4);
            appCostTextbox.MaxLength = 2;
            appCostTextbox.Name = "appCostTextbox";
            appCostTextbox.Size = new Size(147, 27);
            appCostTextbox.TabIndex = 19;
            // 
            // yearlyBillTextbox
            // 
            yearlyBillTextbox.Enabled = false;
            yearlyBillTextbox.Location = new Point(72, 469);
            yearlyBillTextbox.Margin = new Padding(3, 4, 3, 4);
            yearlyBillTextbox.MaxLength = 2;
            yearlyBillTextbox.Name = "yearlyBillTextbox";
            yearlyBillTextbox.Size = new Size(147, 27);
            yearlyBillTextbox.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(79, 437);
            label8.Name = "label8";
            label8.Size = new Size(145, 28);
            label8.TabIndex = 17;
            label8.Text = "Total Yearly Bill:";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(72, 371);
            label7.Name = "label7";
            label7.Size = new Size(168, 28);
            label7.TabIndex = 16;
            label7.Text = "Total Monthly Bill:";
            label7.Click += label7_Click;
            // 
            // monthlyBillTextbox
            // 
            monthlyBillTextbox.Enabled = false;
            monthlyBillTextbox.Location = new Point(72, 403);
            monthlyBillTextbox.Margin = new Padding(3, 4, 3, 4);
            monthlyBillTextbox.MaxLength = 2;
            monthlyBillTextbox.Name = "monthlyBillTextbox";
            monthlyBillTextbox.Size = new Size(147, 27);
            monthlyBillTextbox.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(94, 343);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 14;
            label6.Text = "Summary";
            // 
            // hrsPerDayTextbox
            // 
            hrsPerDayTextbox.Enabled = false;
            hrsPerDayTextbox.Location = new Point(79, 128);
            hrsPerDayTextbox.Margin = new Padding(3, 4, 3, 4);
            hrsPerDayTextbox.MaxLength = 2;
            hrsPerDayTextbox.Name = "hrsPerDayTextbox";
            hrsPerDayTextbox.Size = new Size(209, 27);
            hrsPerDayTextbox.TabIndex = 13;
            hrsPerDayTextbox.KeyPress += hrsPerDayTextbox_KeyPress;
            // 
            // wattageTextbox
            // 
            wattageTextbox.Enabled = false;
            wattageTextbox.Location = new Point(72, 89);
            wattageTextbox.Margin = new Padding(3, 4, 3, 4);
            wattageTextbox.MaxLength = 5;
            wattageTextbox.Name = "wattageTextbox";
            wattageTextbox.Size = new Size(215, 27);
            wattageTextbox.TabIndex = 12;
            wattageTextbox.TextChanged += wattageTextbox_TextChanged;
            wattageTextbox.KeyPress += wattageTextbox_KeyPress;
            // 
            // kwhRateTextbox
            // 
            kwhRateTextbox.Enabled = false;
            kwhRateTextbox.Location = new Point(94, 216);
            kwhRateTextbox.Margin = new Padding(3, 4, 3, 4);
            kwhRateTextbox.MaxLength = 6;
            kwhRateTextbox.Name = "kwhRateTextbox";
            kwhRateTextbox.Size = new Size(111, 27);
            kwhRateTextbox.TabIndex = 11;
            kwhRateTextbox.Text = "14.28";
            kwhRateTextbox.TextChanged += kwhRateTextbox_TextChanged;
            kwhRateTextbox.KeyPress += kwhRateTextbox_KeyPress;
            // 
            // customRateCheckbox
            // 
            customRateCheckbox.AutoSize = true;
            customRateCheckbox.Location = new Point(210, 219);
            customRateCheckbox.Margin = new Padding(3, 4, 3, 4);
            customRateCheckbox.Name = "customRateCheckbox";
            customRateCheckbox.Size = new Size(81, 24);
            customRateCheckbox.TabIndex = 10;
            customRateCheckbox.Text = "Custom";
            customRateCheckbox.UseVisualStyleBackColor = true;
            customRateCheckbox.CheckedChanged += customRateCheckbox_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 224);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 9;
            label5.Text = "kWh Rate:";
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ButtonFace;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Enabled = false;
            saveButton.FlatStyle = FlatStyle.System;
            saveButton.Location = new Point(141, 167);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(147, 41);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 132);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Hours/Day:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 93);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 4;
            label1.Text = "Wattage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 55);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // appNameTextbox
            // 
            appNameTextbox.Enabled = false;
            appNameTextbox.Location = new Point(58, 51);
            appNameTextbox.Margin = new Padding(3, 4, 3, 4);
            appNameTextbox.MaxLength = 20;
            appNameTextbox.Name = "appNameTextbox";
            appNameTextbox.Size = new Size(229, 27);
            appNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(291, 40);
            label2.TabIndex = 0;
            label2.Text = "Appliance Info";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // aboutButton
            // 
            aboutButton.BackColor = Color.PeachPuff;
            aboutButton.Cursor = Cursors.Hand;
            aboutButton.FlatStyle = FlatStyle.System;
            aboutButton.Location = new Point(438, 660);
            aboutButton.Margin = new Padding(3, 4, 3, 4);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(127, 41);
            aboutButton.TabIndex = 8;
            aboutButton.Text = "About..";
            aboutButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 716);
            Controls.Add(aboutButton);
            Controls.Add(panel1);
            Controls.Add(deleteButton);
            Controls.Add(newButton);
            Controls.Add(applianceList);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = ".";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Label label10;
    }
}