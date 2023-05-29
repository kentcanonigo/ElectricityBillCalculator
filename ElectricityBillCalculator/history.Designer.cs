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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            okButton = new Button();
            historyLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            monthlyTbx = new TextBox();
            yearlyTbx = new TextBox();
            historyListbox = new ListBox();
            historyPanel = new Panel();
            historyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Cursor = Cursors.Hand;
            okButton.Font = new Font("Geomanist", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(83, 422);
            okButton.Name = "okButton";
            okButton.Size = new Size(113, 31);
            okButton.TabIndex = 9;
            okButton.Text = "Close";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // historyLabel
            // 
            historyLabel.AutoSize = true;
            historyLabel.BackColor = Color.Transparent;
            historyLabel.Font = new Font("ArterioNonCommercial", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            historyLabel.ForeColor = Color.White;
            historyLabel.Location = new Point(12, 23);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(260, 19);
            historyLabel.TabIndex = 11;
            historyLabel.Text = "Your Past Calculations";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Moon", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 376);
            label1.Name = "label1";
            label1.Size = new Size(63, 12);
            label1.TabIndex = 12;
            label1.Text = "Monthly";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Moon", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(180, 376);
            label2.Name = "label2";
            label2.Size = new Size(48, 12);
            label2.TabIndex = 13;
            label2.Text = "Yearly";
            // 
            // monthlyTbx
            // 
            monthlyTbx.Enabled = false;
            monthlyTbx.Location = new Point(27, 393);
            monthlyTbx.Name = "monthlyTbx";
            monthlyTbx.ReadOnly = true;
            monthlyTbx.Size = new Size(113, 23);
            monthlyTbx.TabIndex = 14;
            // 
            // yearlyTbx
            // 
            yearlyTbx.Enabled = false;
            yearlyTbx.Location = new Point(148, 393);
            yearlyTbx.Name = "yearlyTbx";
            yearlyTbx.ReadOnly = true;
            yearlyTbx.Size = new Size(113, 23);
            yearlyTbx.TabIndex = 15;
            // 
            // historyListbox
            // 
            historyListbox.FormattingEnabled = true;
            historyListbox.ItemHeight = 15;
            historyListbox.Location = new Point(0, 0);
            historyListbox.Name = "historyListbox";
            historyListbox.Size = new Size(260, 304);
            historyListbox.TabIndex = 0;
            historyListbox.SelectedIndexChanged += historyListbox_SelectedIndexChanged;
            historyListbox.SelectedValueChanged += historyListbox_SelectedValueChanged;
            // 
            // historyPanel
            // 
            historyPanel.BackColor = SystemColors.ControlLight;
            historyPanel.Controls.Add(historyListbox);
            historyPanel.Location = new Point(12, 58);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(260, 301);
            historyPanel.TabIndex = 10;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.wpSignUpBg;
            ClientSize = new Size(286, 467);
            Controls.Add(yearlyTbx);
            Controls.Add(monthlyTbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(historyLabel);
            Controls.Add(historyPanel);
            Controls.Add(okButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "history";
            Text = "History";
            historyPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label historyLabel;
        private Label label1;
        private Label label2;
        private TextBox monthlyTbx;
        private TextBox yearlyTbx;
        private Panel historyPanel;
        public ListBox historyListbox;
    }
}