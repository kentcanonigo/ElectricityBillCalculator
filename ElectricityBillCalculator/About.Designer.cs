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
            contactLink = new LinkLabel();
            okButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 23);
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
            label2.Location = new Point(115, 104);
            label2.Name = "label2";
            label2.Size = new Size(104, 16);
            label2.TabIndex = 1;
            label2.Text = "Found any bugs?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contactLink
            // 
            contactLink.AutoSize = true;
            contactLink.Cursor = Cursors.Hand;
            contactLink.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            contactLink.Location = new Point(128, 119);
            contactLink.Name = "contactLink";
            contactLink.Size = new Size(73, 16);
            contactLink.TabIndex = 2;
            contactLink.TabStop = true;
            contactLink.Text = "Contact Us!";
            // 
            // okButton
            // 
            okButton.Cursor = Cursors.Hand;
            okButton.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(126, 151);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 3;
            okButton.Text = "Cool!";
            okButton.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 186);
            Controls.Add(okButton);
            Controls.Add(contactLink);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel contactLink;
        private Button okButton;
    }
}