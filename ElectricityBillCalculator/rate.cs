using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityBillCalculator
{
    public partial class rate : Form
    {
        public rate()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rateBtn1_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = Color.Yellow;
        }

        private void rateBtn2_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = rateBtn2.BackColor = Color.Yellow;
        }

        private void rateBtn3_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = Color.Yellow;
        }

        private void rateBtn4_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = Color.Yellow;
        }

        private void rateBtn5_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.Yellow;
        }
    }
}
