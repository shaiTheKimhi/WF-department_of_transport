namespace דוח_נהגים
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tDriversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.department_of_TransportationDataSet = new דוח_נהגים.Department_of_TransportationDataSet();
            this.tDriversTableAdapter = new דוח_נהגים.Department_of_TransportationDataSetTableAdapters.TDriversTableAdapter();
            this.tableAdapterManager = new דוח_נהגים.Department_of_TransportationDataSetTableAdapters.TableAdapterManager();
            this.department_of_TransportationDataSet1 = new דוח_נהגים.Department_of_TransportationDataSet1();
            this.tDriversBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tDriversTableAdapter1 = new דוח_נהגים.Department_of_TransportationDataSet1TableAdapters.TDriversTableAdapter();
            this.tableAdapterManager1 = new דוח_נהגים.Department_of_TransportationDataSet1TableAdapters.TableAdapterManager();
            this.tDriversDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tDriversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_of_TransportationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_of_TransportationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDriversBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDriversDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "תצוגה מקדימה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "הדפס";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tDriversBindingSource
            // 
            this.tDriversBindingSource.DataMember = "TDrivers";
            this.tDriversBindingSource.DataSource = this.department_of_TransportationDataSet;
            // 
            // department_of_TransportationDataSet
            // 
            this.department_of_TransportationDataSet.DataSetName = "Department_of_TransportationDataSet";
            this.department_of_TransportationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tDriversTableAdapter
            // 
            this.tDriversTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TDriversTableAdapter = this.tDriversTableAdapter;
            this.tableAdapterManager.UpdateOrder = דוח_נהגים.Department_of_TransportationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // department_of_TransportationDataSet1
            // 
            this.department_of_TransportationDataSet1.DataSetName = "Department_of_TransportationDataSet1";
            this.department_of_TransportationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tDriversBindingSource1
            // 
            this.tDriversBindingSource1.DataMember = "TDrivers";
            this.tDriversBindingSource1.DataSource = this.department_of_TransportationDataSet1;
            // 
            // tDriversTableAdapter1
            // 
            this.tDriversTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TDriversTableAdapter = this.tDriversTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = דוח_נהגים.Department_of_TransportationDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tDriversDataGridView
            // 
            this.tDriversDataGridView.AutoGenerateColumns = false;
            this.tDriversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tDriversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tDriversDataGridView.DataSource = this.tDriversBindingSource1;
            this.tDriversDataGridView.Location = new System.Drawing.Point(12, 78);
            this.tDriversDataGridView.Name = "tDriversDataGridView";
            this.tDriversDataGridView.Size = new System.Drawing.Size(645, 199);
            this.tDriversDataGridView.TabIndex = 2;
            this.tDriversDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tDriversDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DriverID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DriverID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "License";
            this.dataGridViewTextBoxColumn6.HeaderText = "License";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "דוח נהג";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printDialog2
            // 
            this.printDialog2.Document = this.printDocument2;
            this.printDialog2.UseEXDialog = true;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // pageSetupDialog2
            // 
            this.pageSetupDialog2.Document = this.printDocument2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tDriversDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tDriversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_of_TransportationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_of_TransportationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDriversBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDriversDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Department_of_TransportationDataSet department_of_TransportationDataSet;
        private System.Windows.Forms.BindingSource tDriversBindingSource;
        private Department_of_TransportationDataSetTableAdapters.TDriversTableAdapter tDriversTableAdapter;
        private Department_of_TransportationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Department_of_TransportationDataSet1 department_of_TransportationDataSet1;
        private System.Windows.Forms.BindingSource tDriversBindingSource1;
        private Department_of_TransportationDataSet1TableAdapters.TDriversTableAdapter tDriversTableAdapter1;
        private Department_of_TransportationDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView tDriversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
    }
}

