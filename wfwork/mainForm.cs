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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void tDriversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tDriversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.department_of_TransportationDataSet4);

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet4.TDrivers' table. You can move, or remove it, as needed.
            this.tDriversTableAdapter.Fill(this.department_of_TransportationDataSet4.TDrivers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tDriversBindingSource.EndEdit();
            tDriversTableAdapter.Update(this.department_of_TransportationDataSet4.TDrivers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tDriversBindingSource.AddNew();
        }
    }
}
