namespace ElectricityBillCalculator
{
    partial class rate
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
            label1 = new Label();
            label2 = new Label();
            rateBtn1 = new roundBtn();
            rateBtn2 = new roundBtn();
            rateBtn5 = new roundBtn();
            rateBtn4 = new roundBtn();
            rateBtn3 = new roundBtn();
            textBox1 = new TextBox();
            okButton = new Button();
            starBtn1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(55, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 16);
            label1.TabIndex = 0;
            label1.Text = "Rate: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 69);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 1;
            label2.Text = "Comment: ";
            // 
            // rateBtn1
            // 
            rateBtn1.BackColor = Color.White;
            rateBtn1.FlatAppearance.BorderSize = 0;
            rateBtn1.FlatStyle = FlatStyle.Flat;
            rateBtn1.Location = new Point(94, 29);
            rateBtn1.Name = "rateBtn1";
            rateBtn1.Size = new Size(25, 25);
            rateBtn1.TabIndex = 2;
            rateBtn1.UseVisualStyleBackColor = false;
            rateBtn1.Click += rateBtn1_Click;
            // 
            // rateBtn2
            // 
            rateBtn2.BackColor = Color.White;
            rateBtn2.FlatAppearance.BorderSize = 0;
            rateBtn2.FlatStyle = FlatStyle.Flat;
            rateBtn2.Location = new Point(125, 29);
            rateBtn2.Name = "rateBtn2";
            rateBtn2.Size = new Size(25, 25);
            rateBtn2.TabIndex = 3;
            rateBtn2.UseVisualStyleBackColor = false;
            rateBtn2.Click += rateBtn2_Click;
            // 
            // rateBtn5
            // 
            rateBtn5.BackColor = Color.White;
            rateBtn5.FlatAppearance.BorderSize = 0;
            rateBtn5.FlatStyle = FlatStyle.Flat;
            rateBtn5.Location = new Point(218, 29);
            rateBtn5.Name = "rateBtn5";
            rateBtn5.Size = new Size(25, 25);
            rateBtn5.TabIndex = 4;
            rateBtn5.UseVisualStyleBackColor = false;
            rateBtn5.Click += rateBtn5_Click;
            // 
            // rateBtn4
            // 
            rateBtn4.BackColor = Color.White;
            rateBtn4.FlatAppearance.BorderSize = 0;
            rateBtn4.FlatStyle = FlatStyle.Flat;
            rateBtn4.Location = new Point(187, 29);
            rateBtn4.Name = "rateBtn4";
            rateBtn4.Size = new Size(25, 25);
            rateBtn4.TabIndex = 5;
            rateBtn4.UseVisualStyleBackColor = false;
            rateBtn4.Click += rateBtn4_Click;
            // 
            // rateBtn3
            // 
            rateBtn3.BackColor = Color.White;
            rateBtn3.FlatAppearance.BorderSize = 0;
            rateBtn3.FlatStyle = FlatStyle.Flat;
            rateBtn3.Location = new Point(156, 29);
            rateBtn3.Name = "rateBtn3";
            rateBtn3.Size = new Size(25, 25);
            rateBtn3.TabIndex = 6;
            rateBtn3.UseVisualStyleBackColor = false;
            rateBtn3.Click += rateBtn3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 67);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 83);
            textBox1.TabIndex = 7;
            // 
            // okButton
            // 
            okButton.Cursor = Cursors.Hand;
            okButton.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(94, 157);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 8;
            okButton.Text = "Cool!";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // starBtn1
            // 
            starBtn1.BackColor = Color.Transparent;
            starBtn1.FlatAppearance.BorderSize = 0;
            starBtn1.FlatStyle = FlatStyle.Flat;
            starBtn1.ForeColor = Color.Transparent;
            starBtn1.Location = new Point(267, 33);
            starBtn1.Name = "starBtn1";
            starBtn1.Size = new Size(30, 30);
            starBtn1.TabIndex = 9;
            starBtn1.UseVisualStyleBackColor = false;
            starBtn1.Paint += starBtn1_Paint;
            // 
            // rate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.wpSignUpBg;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(336, 207);
            Controls.Add(starBtn1);
            Controls.Add(okButton);
            Controls.Add(textBox1);
            Controls.Add(rateBtn3);
            Controls.Add(rateBtn4);
            Controls.Add(rateBtn5);
            Controls.Add(rateBtn2);
            Controls.Add(rateBtn1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "rate";
            Text = "rate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private roundBtn rateBtn1;
        private roundBtn rateBtn2;
        private roundBtn rateBtn5;
        private roundBtn rateBtn4;
        private roundBtn rateBtn3;
        private TextBox textBox1;
        private Button okButton;
        private Button starBtn1;
    }
}