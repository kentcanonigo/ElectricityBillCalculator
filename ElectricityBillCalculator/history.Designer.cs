namespace ElectricityBillCalculator
{
    partial class history
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
            okButton = new Button();
            historyPanel = new Panel();
            historyLabel = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Cursor = Cursors.Hand;
            okButton.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(141, 444);
            okButton.Name = "okButton";
            okButton.Size = new Size(113, 31);
            okButton.TabIndex = 9;
            okButton.Text = "Cool!";
            okButton.UseVisualStyleBackColor = true;
            // 
            // historyPanel
            // 
            historyPanel.BackColor = SystemColors.ControlLight;
            historyPanel.Location = new Point(31, 68);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(341, 365);
            historyPanel.TabIndex = 10;
            // 
            // historyLabel
            // 
            historyLabel.AutoSize = true;
            historyLabel.BackColor = Color.Transparent;
            historyLabel.Font = new Font("ArterioNonCommercial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            historyLabel.ForeColor = Color.White;
            historyLabel.Location = new Point(40, 33);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(330, 24);
            historyLabel.TabIndex = 11;
            historyLabel.Text = "Your Past Calculations";
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.wpSignUpBg;
            ClientSize = new Size(404, 499);
            Controls.Add(historyLabel);
            Controls.Add(historyPanel);
            Controls.Add(okButton);
            Name = "history";
            Text = "history";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Panel historyPanel;
        private Label historyLabel;
    }
}