using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ElectricityBillCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            applianceList.Items.Add(new Appliance("Test Appliance", 50, 24)); //Create a test appliance to start
            applianceList.Items.Add(new Appliance("Test Appliance 2", 25, 16)); //Create a test appliance to start
        }

        public class Appliance
        {
            public Appliance(string name, int wattage, int hrsPerDay)
            {
                this.Name = name;
                this.Wattage = wattage;
                this.HrsPerDay = hrsPerDay;
            }

            public override string ToString() //Required to display proper appliance name in list
            {
                return Name;
            }

            public string Name;
            public Int32 Wattage;
            public Int32 HrsPerDay;
        }

        private bool alreadyExist(string _text, ref char KeyChar) //Checks if a period already exists in a textbox.
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
        }

        private void customRateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!customRateCheckbox.Checked)
            {
                kwhRateTextbox.Text = "14.28";
            }
            kwhRateTextbox.Enabled = !kwhRateTextbox.Enabled;
        }

        private void kwhRateTextbox_KeyPress(object sender, KeyPressEventArgs e) //Only allows 1 period and 2 decimals in textbox
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (kwhRateTextbox.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (kwhRateTextbox.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(kwhRateTextbox.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (kwhRateTextbox.SelectionStart != kwhRateTextbox.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = kwhRateTextbox.Text.Substring(kwhRateTextbox.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(kwhRateTextbox.Text, ref sepratorChar))
                {
                    int sepratorPosition = kwhRateTextbox.Text.IndexOf(sepratorChar);
                    string afterSepratorString = kwhRateTextbox.Text.Substring(sepratorPosition + 1);
                    if (kwhRateTextbox.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private void wattageTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wattageTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void hrsPerDayTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void applianceList_SelectedValueChanged(object sender, EventArgs e) //Event handling for appliance list. (Update properties)
        {
            Appliance currentAppliance = (Appliance)applianceList.SelectedItem;
            if (currentAppliance == null) //Return if there is no current appliance
            {
                return;
            }
            editButton.Enabled = true;
            appNameTextbox.Text = currentAppliance.Name;
            wattageTextbox.Text = currentAppliance.Wattage.ToString();
            hrsPerDayTextbox.Text = currentAppliance.HrsPerDay.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (applianceList.Items.Count <= 0)
            {
                return;
            }
            saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Appliance currentAppliance = (Appliance)applianceList.SelectedItem;
            if (currentAppliance == null)
            {
                return;
            }
            currentAppliance.Name = appNameTextbox.Text;
            currentAppliance.Wattage = Int32.Parse(wattageTextbox.Text);
            currentAppliance.HrsPerDay = Int32.Parse(hrsPerDayTextbox.Text);
            saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = false;
            applianceList.DrawMode = DrawMode.OwnerDrawFixed;
            applianceList.DrawMode = DrawMode.Normal;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            while (applianceList.SelectedItems.Count > 0)
            {
                applianceList.Items.RemoveAt(applianceList.SelectedIndex);
            }
            ResetButtons();
        }

        private void applianceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (applianceList.Items.Count <= 0)
            {
                ResetButtons();
            }
        }

        private void ResetButtons()
        {
            appNameTextbox.Text = string.Empty;
            wattageTextbox.Text = string.Empty;
            hrsPerDayTextbox.Text = string.Empty;
            editButton.Enabled = saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = false;
        }
    }
}