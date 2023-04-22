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
            hrsPerDayTextbox = new TextBox();
            wattageTextbox = new TextBox();
            kwhRateTextbox = new TextBox();
            customRateCheckbox = new CheckBox();
            label5 = new Label();
            button1 = new Button();
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
            applianceList.FormattingEnabled = true;
            applianceList.ItemHeight = 15;
            applianceList.Location = new Point(12, 65);
            applianceList.Name = "applianceList";
            applianceList.Size = new Size(221, 424);
            applianceList.TabIndex = 1;
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
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.ButtonFace;
            editButton.Cursor = Cursors.Hand;
            editButton.FlatStyle = FlatStyle.System;
            editButton.Location = new Point(3, 133);
            editButton.Name = "editButton";
            editButton.Size = new Size(64, 31);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(hrsPerDayTextbox);
            panel1.Controls.Add(wattageTextbox);
            panel1.Controls.Add(kwhRateTextbox);
            panel1.Controls.Add(customRateCheckbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
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
            kwhRateTextbox.Location = new Point(69, 225);
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
            customRateCheckbox.Location = new Point(69, 254);
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
            label5.Location = new Point(3, 228);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 9;
            label5.Text = "kWh Rate:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Hand;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(73, 133);
            button1.Name = "button1";
            button1.Size = new Size(44, 31);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
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
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
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
        private Button button1;
        private Button aboutButton;
        private CheckBox customRateCheckbox;
        private Label label5;
        private Label label4;
        private TextBox kwhRateTextbox;
        private TextBox hrsPerDayTextbox;
        private TextBox wattageTextbox;
    }
}