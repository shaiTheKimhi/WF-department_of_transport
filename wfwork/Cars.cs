using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace wfwork
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void tCarsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tCarsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.department_of_TransportationDataSet4);

        }

        private void Cars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet4.שאילתה2' table. You can move, or remove it, as needed.
            this.שאילתה2TableAdapter.Fill(this.department_of_TransportationDataSet4.שאילתה2);
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet4.שאילתה1' table. You can move, or remove it, as needed.
            this.שאילתה1TableAdapter.Fill(this.department_of_TransportationDataSet4.שאילתה1);
            this.שאילתה1TableAdapter.Fill(this.department_of_TransportationDataSet4.שאילתה1);
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet4.TDrivers' table. You can move, or remove it, as needed.
            this.tDriversTableAdapter.Fill(this.department_of_TransportationDataSet4.TDrivers);
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet4.TCars' table. You can move, or remove it, as needed.
            this.tCarsTableAdapter.Fill(this.department_of_TransportationDataSet4.TCars);
            chart1.Visible = false;
            chart2.Visible = false;
            showUsersAndCars();

        }
        public void showUsersAndCars()
        {
            var select = "SELECT DriverID,COUNT(numCar) as cars From TCars Group by DriverID";
            string s = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\Documents\Visual Studio 2017\Projects\wfwork\Department_of_Transportation.accdb'"); // Your Connection String here
            var da = new OleDbDataAdapter(select, s);
            
            // var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(department_of_TransportationDataSet4.TDrivers);
            tCarsDataGridView.DataSource = dv;
            DataView dv1 = new DataView(department_of_TransportationDataSet4.TCars);
            string st= "DriverID = " + tCarsDataGridView.Rows[comboBox1.SelectedIndex].Cells[4].FormattedValue.ToString();
            dv1.RowFilter = st;
            tCarsDataGridView.DataSource = dv1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="show diagram")
            {
                button2.Text = "hide diagram";
                chart1.Visible = true;
                chart2.Visible = true;
            }
            else
            {
                button2.Text = "show diagram";
                chart1.Visible = false;
                chart2.Visible = false;
            }
        }
    }
}
