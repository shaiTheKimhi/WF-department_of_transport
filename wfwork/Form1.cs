using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfwork
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void tDriversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.tDriversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.department_of_TransportationDataSet2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*mainForm mf = new mainForm();
            mf.ShowDialog();*/

            // TODO: This line of code loads data into the 'department_of_TransportationDataSet2.TDrivers' table. You can move, or remove it, as needed.
            this.tDriversTableAdapter.Fill(this.department_of_TransportationDataSet2.TDrivers);
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet.TDrivers' table. You can move, or remove it, as needed.
            //this.tDriversTableAdapter.Fill(this.department_of_TransportationDataSet.TDrivers);
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tDriversBindingSource.AddNew();
            button2.Visible = true;
            button9.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<department_of_TransportationDataSet2.TDrivers.Rows.Count;i++)
            {
                if(tDriversDataGridView.Rows[i].Cells[0].Value.ToString()==driverIDTextBox.Text)
                {
                    MessageBox.Show("already exists");
                    return;
                }
            }
            if (driverIDTextBox.Text == "")
                return;
            if (fullNameTextBox.Text == "")
                return;
            if (addressTextBox.Text == "")
                return;
            if (phoneNumberTextBox.Text == "")
                return;
            if (licenseTextBox.Text == "")
                return;
            if(driverIDTextBox.Text.Length!=9)
            {
                MessageBox.Show("need to be 9 digits");
                return;
            }
            if(phoneNumberTextBox.Text.Length!=10)
            {
                MessageBox.Show("needs to be 10 digits");
                return;
            }
            //MIGHT CHANGE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if((DateTime.Now- birthDateDateTimePicker.Value.Date).Days/365.0f<17)
            {
                MessageBox.Show("Must be at least 17 years old");
                return;
            }
            //check address
            tDriversBindingSource.EndEdit();
            tDriversTableAdapter.Update(this.department_of_TransportationDataSet2.TDrivers);
            button9.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { tDriversBindingSource.MoveNext(); } catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { tDriversBindingSource.MovePrevious(); } catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { tDriversBindingSource.MoveFirst(); } catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { tDriversBindingSource.MoveLast(); } catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tDriversBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tDriversDataGridView.Refresh();
        }

        private void driverIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar>='0'&&e.KeyChar<='9'||e.KeyChar=='\b'))
            {
                e.Handled = true;
                MessageBox.Show("numbers only");
            }

        }

        private void fullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar>='א'&&e.KeyChar<='ת')||e.KeyChar==' ' || e.KeyChar=='"'||e.KeyChar=='\b')
            {

            }
            else
            {
                MessageBox.Show("only hebrew letters ");
                e.Handled = true;
            }
        }

        private void addressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar>='0'&&e.KeyChar<='9'))
            {
                e.Handled = true;
                MessageBox.Show("only number");
            }
        }

        private void lisenceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            { }
            else
            {
                e.Handled = true;
                MessageBox.Show("only numbers");
            }
        }

        private void tDriversBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tDriversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.department_of_TransportationDataSet2);

        }

        private void driverIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void driverIDTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b'))
            {
                e.Handled = true;
                MessageBox.Show("numbers only");
            }

        }

        private void addressTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void phoneNumberTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true;
                MessageBox.Show("only number");
            }
        }

        private void licenseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            { }
            else
            {
                e.Handled = true;
                MessageBox.Show("only numbers");
            }
        }

        private void fullNameTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'א' && e.KeyChar <= 'ת') || e.KeyChar == ' ' || e.KeyChar == '"' || e.KeyChar == '\b')
            {

            }
            else
            {
                MessageBox.Show("only hebrew letters ");
                e.Handled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (driverIDTextBox.Text == "")
                return;
            if (fullNameTextBox.Text == "")
                return;
            if (addressTextBox.Text == "")
                return;
            if (phoneNumberTextBox.Text == "")
                return;
            if (licenseTextBox.Text == "")
                return;
            if (driverIDTextBox.Text.Length != 9)
            {
                MessageBox.Show("need to be 9 digits");
                return;
            }
            if (phoneNumberTextBox.Text.Length != 10)
            {
                MessageBox.Show("needs to be 10 digits");
                return;
            }
            if (DateTime.Now.Year - birthDateDateTimePicker.Value.Date.Year < 17)
            {
                MessageBox.Show("Must be at least 17 years old");
                return;
            }
            //check address
            tDriversBindingSource.EndEdit();
            tDriversTableAdapter.Update(this.department_of_TransportationDataSet2.TDrivers);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(sDriver.Text!="")
            {
                string name = sDriver.Text;
                DataView query = new DataView(department_of_TransportationDataSet2.TDrivers);
                string sql = string.Format("FullName='{0}'",name);
                query.RowFilter = sql;
                tDriversDataGridView.DataSource = query;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DriversForm df = new DriversForm();
            this.Hide();
            df.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cars c = new Cars();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}
