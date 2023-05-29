namespace ElectricityBillCalculator
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            addBtn = new roundBtn();
            infoHelp = new roundBtn();
            calcHelp = new roundBtn();
            ExtraHelp = new roundBtn();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addBtn.BackgroundImage = Properties.Resources.addHelp;
            addBtn.BackgroundImageLayout = ImageLayout.Center;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Location = new Point(138, 346);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(48, 48);
            addBtn.TabIndex = 0;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // infoHelp
            // 
            infoHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoHelp.BackgroundImage = (Image)resources.GetObject("infoHelp.BackgroundImage");
            infoHelp.BackgroundImageLayout = ImageLayout.Center;
            infoHelp.FlatAppearance.BorderSize = 0;
            infoHelp.FlatStyle = FlatStyle.Flat;
            infoHelp.Location = new Point(285, 346);
            infoHelp.Name = "infoHelp";
            infoHelp.Size = new Size(48, 48);
            infoHelp.TabIndex = 1;
            infoHelp.UseVisualStyleBackColor = true;
            infoHelp.Click += infoHelp_Click;
            // 
            // calcHelp
            // 
            calcHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calcHelp.BackgroundImage = Properties.Resources.calcHelp;
            calcHelp.BackgroundImageLayout = ImageLayout.Center;
            calcHelp.FlatAppearance.BorderSize = 0;
            calcHelp.FlatStyle = FlatStyle.Flat;
            calcHelp.Location = new Point(430, 346);
            calcHelp.Name = "calcHelp";
            calcHelp.Size = new Size(48, 48);
            calcHelp.TabIndex = 2;
            calcHelp.UseVisualStyleBackColor = true;
            calcHelp.Click += calcHelp_Click;
            // 
            // ExtraHelp
            // 
            ExtraHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExtraHelp.BackgroundImage = (Image)resources.GetObject("ExtraHelp.BackgroundImage");
            ExtraHelp.BackgroundImageLayout = ImageLayout.Center;
            ExtraHelp.FlatAppearance.BorderSize = 0;
            ExtraHelp.FlatStyle = FlatStyle.Flat;
            ExtraHelp.Location = new Point(574, 346);
            ExtraHelp.Name = "ExtraHelp";
            ExtraHelp.Size = new Size(48, 48);
            ExtraHelp.TabIndex = 3;
            ExtraHelp.UseVisualStyleBackColor = true;
            ExtraHelp.Click += ExtraHelp_Click;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(742, 571);
            Controls.Add(ExtraHelp);
            Controls.Add(calcHelp);
            Controls.Add(infoHelp);
            Controls.Add(addBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Help";
            Text = "App Functionalities";
            ResumeLayout(false);
        }

        #endregion

        private roundBtn addBtn;
        private roundBtn infoHelp;
        private roundBtn calcHelp;
        private roundBtn ExtraHelp;
    }
}