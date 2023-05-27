using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityBillCalculator
{
    public partial class Help : Form
    {
        public Help(ListBox applianceList, Button calculateButton, TextBox appNameTextBox, TextBox wattageTextBox, TextBox hrsPerDayTextBox, TextBox daysUsedTextBox)
        {
            InitializeComponent();
            this.applianceList = applianceList;
            this.appNameTextBox = appNameTextBox;
            this.wattageTextBox = wattageTextBox;
            this.hrsPerDayTextBox = hrsPerDayTextBox;
            this.daysUsedTextBox = daysUsedTextBox;
            this.calculateButton = calculateButton;
        }

        private ListBox applianceList;
        private TextBox appNameTextBox;
        private TextBox wattageTextBox;
        private TextBox hrsPerDayTextBox;
        private TextBox daysUsedTextBox;
        private Button calculateButton;

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2(applianceList);
            add.Show();
            this.Close();
        }

        private void infoHelp_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["MainForm"] != null)
            {
                this.Close();
                (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).ShowHelp();
            }
        }

        private void calcHelp_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["MainForm"] != null)
            {
                this.Close();
                (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).ShowCalc();
            }
        }

        private void ExtraHelp_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["MainForm"] != null)
            {
                this.Close();
                (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).ShowExtra();
            }
        }
    }
}
