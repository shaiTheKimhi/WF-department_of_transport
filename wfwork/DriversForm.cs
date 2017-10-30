using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace wfwork
{
    public partial class DriversForm : Form
    {
        const int line = 22;
        public DriversForm()
        {
            InitializeComponent();
        }

        private void tDriversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tDriversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.department_of_TransportationDataSet4);

        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet4.TDrivers' table. You can move, or remove it, as needed.
            this.tDriversTableAdapter.Fill(this.department_of_TransportationDataSet4.TDrivers);
            timer2.Enabled = false;
            button2.Enabled = false;
            tDriversDataGridView.Enabled = false;
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            comboBox1.Enabled = false;
            //comboBox1.Items.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView data = new DataView(department_of_TransportationDataSet4.TDrivers);
            data.RowFilter = "";
            tDriversDataGridView.DataSource = data;
            //timer2.Enabled = true;
            button2.Enabled = true;
            checkBox1.Enabled = true;
            /*comboBox1.Items.Add("");
            for(int i=0;i<tDriversDataGridView.Rows.Count;i++)
            {
                comboBox1.Items.Add(tDriversDataGridView.Rows[i].Cells[0].FormattedValue.ToString());
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fil = "";
            List<string> sql= new List<string>();
            if (name.Text != "")
                sql.Add("FullName like'*" + name.Text + "*'");
            if (address.Text != "")
                sql.Add("Address like '*" + address.Text + "*'");
            if(comboBox1.SelectedItem!=null)
                if (!comboBox1.SelectedItem.Equals("")&&checkBox1.Checked==true)
                    sql.Add("DriverID='"+tDriversDataGridView.Rows[comboBox1.SelectedIndex].Cells[0].FormattedValue.ToString()+"'");
            foreach(string part in sql)
            {
                fil += part+" AND ";
            }
            fil += "1=1";
            DataView dv = new DataView(department_of_TransportationDataSet4.TDrivers);
            dv.RowFilter = fil;
            tDriversDataGridView.DataSource = dv;
            label4.Text = "מספר רשומות שנמצאו:" + (tDriversDataGridView.Rows.Count-1).ToString();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tDriversTableAdapter.FillBy(this.department_of_TransportationDataSet4.TDrivers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            for(int i=0;i<tDriversDataGridView.Rows.Count-1;i++)
            {
                comboBox1.Items.Add(tDriversDataGridView.Rows[i].Cells[0].FormattedValue.ToString());
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                comboBox1.Enabled = true;
            else
                comboBox1.Enabled = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0, j;
            int w = 100, h = 200;
            Pen p = new Pen(Brushes.Black, 2.5f);
            //Printing Title
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("דוח רכבים", new Font("Arial", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));
            //printing titles (upper line)
            while (i < tDriversDataGridView.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                e.Graphics.DrawString(tDriversDataGridView.Columns[i].HeaderText.ToString(), tDriversDataGridView.Font, Brushes.Black, new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                i++;
                w += 100;
            }
            //printing content
            i = 0;
            while (i < tDriversDataGridView.Rows.Count - 1)
            {
                w = 100; h += line;//'h' is the height of the row in the document
                j = 0;
                while (j < tDriversDataGridView.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                    e.Graphics.DrawString(tDriversDataGridView.Rows[i].Cells[j].FormattedValue.ToString()
                    , tDriversDataGridView.Font, Brushes.Black
                    , new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                    j++;
                    w += 100;
                }
                i++;
            }
            string str = "מספר הנהגים:";
            str += tDriversDataGridView.Rows.Count-1;
            e.Graphics.DrawString(str, new Font("Arial", 15, FontStyle.Italic), Brushes.Blue, new Point(100, h + 30));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }

        private void birthDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            { }
            else
            {
                e.Handled=true;
                MessageBox.Show("ספרות בלבד");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(int.Parse(birthDate.Text), 1, 1);
            DateTime dt2 = new DateTime(int.Parse(birthDate.Text), 12, 31);

            DataView dv = new DataView(department_of_TransportationDataSet4.TDrivers);
            string st = string.Format("(BirthDate>='{0}') AND (BirthDate<= '{1}')",dt1,dt2); 
            dv.RowFilter = st;
            tDriversDataGridView.DataSource=dv;
        }
    }
}
