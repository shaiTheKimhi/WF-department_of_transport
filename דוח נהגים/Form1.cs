using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace דוח_נהגים
{
    public partial class Form1 : Form
    {
        const int line = 22;
        public Form1()
        {
            InitializeComponent();
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
            while (i<tDriversDataGridView.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                e.Graphics.DrawString(tDriversDataGridView.Columns[i].HeaderText.ToString(), tDriversDataGridView.Font, Brushes.Black, new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                i++;
                w += 100;
            }
            //printing content
            i = 0;
            while(i<tDriversDataGridView.Rows.Count-1)
            {
                w = 100;h += line;//'h' is the height of the row in the document
                j = 0;
                while(j<tDriversDataGridView.Columns.Count)
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
            str += tDriversDataGridView.Rows.Count;
            e.Graphics.DrawString(str, new Font("Arial", 15, FontStyle.Italic), Brushes.Blue, new Point(100, h + 30));
        }

       

        private void tDriversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tDriversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.department_of_TransportationDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet1.TDrivers' table. You can move, or remove it, as needed.
            this.tDriversTableAdapter1.Fill(this.department_of_TransportationDataSet1.TDrivers);
            // TODO: This line of code loads data into the 'department_of_TransportationDataSet.TDrivers' table. You can move, or remove it, as needed.
            this.tDriversTableAdapter.Fill(this.department_of_TransportationDataSet.TDrivers);
        }

        private void tDriversDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            h += line;
            w = 100;
            for(j=0;j<tDriversDataGridView.CurrentRow.Cells.Count;j++)
            {
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                e.Graphics.DrawString(tDriversDataGridView.CurrentRow.Cells[j].FormattedValue.ToString()
                , tDriversDataGridView.Font, Brushes.Black
                , new Rectangle(w, h, tDriversDataGridView.Columns[0].Width, tDriversDataGridView.Rows[0].Height));
                w += 100;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog2.ShowDialog();
            printPreviewDialog2.ShowDialog();
        }

        private void tDriversDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult prbutton = printDialog1.ShowDialog();
            if (DialogResult.Equals(DialogResult.OK))
                printDocument1.Print();
        }
    }
}
