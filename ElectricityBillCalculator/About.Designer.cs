namespace ElectricityBillCalculator
{
    partial class About
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
            okButton = new Button();
            contactRex = new LinkLabel();
            contactKent = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 13);
            label1.Name = "label1";
            label1.Size = new Size(149, 48);
            label1.TabIndex = 0;
            label1.Text = "This app was created by:\r\nRex C. Sumalinog\r\nKent Y. Canonigo\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(115, 80);
            label2.Name = "label2";
            label2.Size = new Size(104, 16);
            label2.TabIndex = 1;
            label2.Text = "Found any bugs?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            okButton.Cursor = Cursors.Hand;
            okButton.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(126, 156);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 3;
            okButton.Text = "Rate";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // contactRex
            // 
            contactRex.AutoSize = true;
            contactRex.Cursor = Cursors.Hand;
            contactRex.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            contactRex.Location = new Point(112, 113);
            contactRex.Name = "contactRex";
            contactRex.Size = new Size(107, 16);
            contactRex.TabIndex = 4;
            contactRex.TabStop = true;
            contactRex.Text = "Rex C. Sumalinog";
            contactRex.LinkClicked += contactRex_LinkClicked;
            // 
            // contactKent
            // 
            contactKent.AutoSize = true;
            contactKent.Cursor = Cursors.Hand;
            contactKent.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            contactKent.Location = new Point(99, 134);
            contactKent.Name = "contactKent";
            contactKent.Size = new Size(135, 16);
            contactKent.TabIndex = 5;
            contactKent.TabStop = true;
            contactKent.Text = "Rigel Kent Y. Canonigo";
            contactKent.LinkClicked += contactKent_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(123, 96);
            label3.Name = "label3";
            label3.Size = new Size(85, 16);
            label3.TabIndex = 6;
            label3.Text = "Contact us at:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 189);
            Controls.Add(label3);
            Controls.Add(contactKent);
            Controls.Add(contactRex);
            Controls.Add(okButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button okButton;
        private LinkLabel contactRex;
        private LinkLabel contactKent;
        private Label label3;
    }
}