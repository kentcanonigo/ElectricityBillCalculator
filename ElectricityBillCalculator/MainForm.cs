using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ElectricityBillCalculator
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        string username;

        public MainForm(string username)
        {
            InitializeComponent(); //Init();
            //MessageBox.Show(username);
            this.username = username;
            CheckHistory();

            // Set the form's FormBorderStyle property to None, which removes the window border.
            this.FormBorderStyle = FormBorderStyle.None;

            // Create a new Region object for the form's Region property using the FromHrgn method.
            // The FromHrgn method takes the handle to a GDI region and returns a corresponding Region object.
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        string connectionString = "server=localhost;user=root;password=;database=testBC";

        public void ShowHelp()
        {
            appNameTextbox.BackColor = wattageTextbox.BackColor = hrsPerDayTextbox.BackColor = daysUsedTextbox.BackColor = Color.PowderBlue;
            MessageBox.Show("Information Highlighted");
            Thread.Sleep(100);
            appNameTextbox.BackColor = wattageTextbox.BackColor = hrsPerDayTextbox.BackColor = daysUsedTextbox.BackColor = SystemColors.Window;
        }

        public void ShowCalc()
        {
            monthlyBillTextbox.BackColor = yearlyBillTextbox.BackColor = calculateButton.BackColor = Color.PowderBlue;
            MessageBox.Show("Information Highlighted");
            Thread.Sleep(100);
            monthlyBillTextbox.BackColor = yearlyBillTextbox.BackColor = calculateButton.BackColor = SystemColors.Window;
        }

        public void ShowExtra()
        {
            newButton.BackColor = deleteButton.BackColor = editButton.BackColor = saveButton.BackColor = aboutButton.BackColor = Color.PowderBlue;
            MessageBox.Show("Button Highlighted");
            Thread.Sleep(100);
            newButton.BackColor = deleteButton.BackColor = editButton.BackColor = saveButton.BackColor = aboutButton.BackColor = SystemColors.Window;
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
            //MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            Form2 addNewAppForm = new Form2(applianceList);
            addNewAppForm.ShowDialog();
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
            UpdateInfo(currentAppliance);
        }

        private void UpdateInfo(Appliance currentAppliance)
        {
            float appCost = ((currentAppliance.Wattage * currentAppliance.HrsPerDay) / 1000.0f) * float.Parse(kwhRateTextbox.Text);
            currentAppliance.AppCost = appCost;
            editButton.Enabled = true;
            appNameTextbox.Text = currentAppliance.Name;
            wattageTextbox.Text = currentAppliance.Wattage.ToString();
            hrsPerDayTextbox.Text = currentAppliance.HrsPerDay.ToString();
            appCostTextbox.Text = "₱" + appCost.ToString();
            daysUsedTextbox.Text = currentAppliance.DaysPerMonth.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (applianceList.Items.Count <= 0)
            {
                return;
            }
            saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = daysUsedTextbox.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Appliance currentAppliance = (Appliance)applianceList.SelectedItem;
            if (currentAppliance == null)
            {
                return;
            }
            currentAppliance.Name = appNameTextbox.Text;
            currentAppliance.Wattage = float.Parse(wattageTextbox.Text);
            currentAppliance.HrsPerDay = float.Parse(hrsPerDayTextbox.Text);
            currentAppliance.DaysPerMonth = float.Parse(daysUsedTextbox.Text);
            saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = daysUsedTextbox.Enabled = false;
            UpdateInfo(currentAppliance);
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
            appCostTextbox.Text = string.Empty;
            wattageTextbox.Text = string.Empty;
            hrsPerDayTextbox.Text = string.Empty;
            daysUsedTextbox.Text = string.Empty;
            editButton.Enabled = saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = daysUsedTextbox.Enabled = false;
        }

        private void kwhRateTextbox_TextChanged(object sender, EventArgs e)
        {
            Appliance currentAppliance = (Appliance)applianceList.SelectedItem;
            if (currentAppliance == null) //Return if there is no current appliance
            {
                return;
            }
            UpdateInfo(currentAppliance);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            float monthlyCost = 0f;
            float yearlyCost = 0f;

            for (int i = 0; i < applianceList.Items.Count; i++)
            {
                Appliance currentAppliance = (Appliance)applianceList.Items[i];
                currentAppliance.AppCost = (((currentAppliance.Wattage * currentAppliance.HrsPerDay) * currentAppliance.DaysPerMonth) / 1000.0f) * float.Parse(kwhRateTextbox.Text);
                //MessageBox.Show(currentAppliance.AppCost.ToString());
                monthlyCost += currentAppliance.AppCost;
            }

            yearlyCost = monthlyCost * 12f;

            monthlyBillTextbox.Text = "₱" + monthlyCost.ToString();
            yearlyBillTextbox.Text = "₱" + yearlyCost.ToString();

            string dateCalculated = DateTime.Now.ToShortDateString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand($"INSERT INTO {username} (monthly_cost, yearly_cost, date_calculated) VALUES (@value1, @value2, @value3)", connection))
                {
                    command.Parameters.AddWithValue("@value1", monthlyCost);
                    command.Parameters.AddWithValue("@value2", yearlyCost);
                    command.Parameters.AddWithValue("@value3", dateCalculated);
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool CheckHistory()
        {
            // Provide the table name and column names
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Table does not exist, create it
                using (MySqlCommand command = new MySqlCommand($"CREATE TABLE IF NOT EXISTS `testbc`.`{username}` (`counter` INT(20) NOT NULL AUTO_INCREMENT , `date_calculated` VARCHAR(50) NOT NULL, `monthly_cost` FLOAT(10) NOT NULL , `yearly_cost` FLOAT(10) NOT NULL , PRIMARY KEY (`counter`))", connection))
                {
                    command.ExecuteNonQuery();
                    //MessageBox.Show("Table created successfully.");
                    return false;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            newButton.Region = deleteButton.Region = editButton.Region = saveButton.Region = aboutButton.Region = calculateButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, newButton.Width, newButton.Height, 10, 10));
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Signout", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Close();
            }
        }

        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Help help = new Help(applianceList, calculateButton, appNameTextbox, wattageTextbox, hrsPerDayTextbox, daysUsedTextbox);
            help.Show();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            history history = new history(username);
            history.Show();
        }
    }
}