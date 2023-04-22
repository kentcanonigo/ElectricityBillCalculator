namespace ElectricityBillCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
        }
    }
}