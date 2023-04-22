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
            label1 = new Label();
            listBox1 = new ListBox();
            newButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(506, 62);
            label1.TabIndex = 0;
            label1.Text = "Electricity Bill Calculator";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(221, 424);
            listBox1.TabIndex = 1;
            // 
            // newButton
            // 
            newButton.BackColor = Color.LemonChiffon;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(12, 495);
            newButton.Name = "newButton";
            newButton.Size = new Size(72, 31);
            newButton.TabIndex = 2;
            newButton.Text = "New...";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Coral;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(172, 495);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(61, 31);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LightCyan;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(90, 495);
            editButton.Name = "editButton";
            editButton.Size = new Size(76, 31);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(239, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 424);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(61, 170);
            button1.Name = "button1";
            button1.Size = new Size(124, 116);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 1;
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
            // button2
            // 
            button2.Location = new Point(76, 341);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 537);
            Controls.Add(panel1);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(newButton);
            Controls.Add(listBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = ".";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button newButton;
        private Button deleteButton;
        private Button editButton;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}