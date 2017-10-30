namespace wfwork
{
    partial class Cars
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
            System.Windows.Forms.Label numCarLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label pYearLabel;
            System.Windows.Forms.Label driverIDLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.department_of_TransportationDataSet4 = new wfwork.Department_of_TransportationDataSet4();
            this.tCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCarsTableAdapter = new wfwork.Department_of_TransportationDataSet4TableAdapters.TCarsTableAdapter();
            this.tableAdapterManager = new wfwork.Department_of_TransportationDataSet4TableAdapters.TableAdapterManager();
            this.tDriversTableAdapter = new wfwork.Department_of_TransportationDataSet4TableAdapters.TDriversTableAdapter();
            this.tCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numCarTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.pYearComboBox = new System.Windows.Forms.ComboBox();
            this.driverIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tDriversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.שאילתה1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.שאילתה1TableAdapter = new wfwork.Department_of_TransportationDataSet4TableAdapters.שאילתה1TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.שאילתה2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.שאילתה2TableAdapter = new wfwork.Department_of_TransportationDataSet4TableAdapters.שאילתה2TableAdapter();
            numCarLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            pYearLabel = new System.Windows.Forms.Label();
            driverIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.department_of_TransportationDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCarsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDriversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.שאילתה1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.שאילתה2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numCarLabel
            // 
            numCarLabel.AutoSize = true;
            numCarLabel.Location = new System.Drawing.Point(2, 15);
            numCarLabel.Name = "numCarLabel";
            numCarLabel.Size = new System.Drawing.Size(49, 13);
            numCarLabel.TabIndex = 2;
            numCarLabel.Text = "num Car:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(21, 41);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(30, 13);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "type:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(18, 67);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(33, 13);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "color:";
            // 
            // pYearLabel
            // 
            pYearLabel.AutoSize = true;
            pYearLabel.Location = new System.Drawing.Point(178, 16);
            pYearLabel.Name = "pYearLabel";
            pYearLabel.Size = new System.Drawing.Size(41, 13);
            pYearLabel.TabIndex = 8;
            pYearLabel.Text = "p Year:";
            // 
            // driverIDLabel
            // 
            driverIDLabel.AutoSize = true;
            driverIDLabel.Location = new System.Drawing.Point(177, 43);
            driverIDLabel.Name = "driverIDLabel";
            driverIDLabel.Size = new System.Drawing.Size(52, 13);
            driverIDLabel.TabIndex = 10;
            driverIDLabel.Text = "Driver ID:";
            // 
            // department_of_TransportationDataSet4
            // 
            this.department_of_TransportationDataSet4.DataSetName = "Department_of_TransportationDataSet4";
            this.department_of_TransportationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCarsBindingSource
            // 
            this.tCarsBindingSource.DataMember = "TCars";
            this.tCarsBindingSource.DataSource = this.department_of_TransportationDataSet4;
            // 
            // tCarsTableAdapter
            // 
            this.tCarsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TCarsTableAdapter = this.tCarsTableAdapter;
            this.tableAdapterManager.TDriversTableAdapter = this.tDriversTableAdapter;
            this.tableAdapterManager.UpdateOrder = wfwork.Department_of_TransportationDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tDriversTableAdapter
            // 
            this.tDriversTableAdapter.ClearBeforeFill = true;
            // 
            // tCarsDataGridView
            // 
            this.tCarsDataGridView.AutoGenerateColumns = false;
            this.tCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tCarsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tCarsDataGridView.DataSource = this.tCarsBindingSource;
            this.tCarsDataGridView.Location = new System.Drawing.Point(24, 113);
            this.tCarsDataGridView.Name = "tCarsDataGridView";
            this.tCarsDataGridView.Size = new System.Drawing.Size(548, 182);
            this.tCarsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numCar";
            this.dataGridViewTextBoxColumn1.HeaderText = "numCar";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn3.HeaderText = "color";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "pYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DriverID";
            this.dataGridViewTextBoxColumn5.HeaderText = "DriverID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(588, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 182);
            this.dataGridView1.TabIndex = 2;
            // 
            // numCarTextBox
            // 
            this.numCarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCarsBindingSource, "numCar", true));
            this.numCarTextBox.Location = new System.Drawing.Point(57, 12);
            this.numCarTextBox.Name = "numCarTextBox";
            this.numCarTextBox.Size = new System.Drawing.Size(100, 20);
            this.numCarTextBox.TabIndex = 3;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCarsBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(57, 38);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 5;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCarsBindingSource, "color", true));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(57, 64);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 7;
            // 
            // pYearComboBox
            // 
            this.pYearComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCarsBindingSource, "pYear", true));
            this.pYearComboBox.FormattingEnabled = true;
            this.pYearComboBox.Location = new System.Drawing.Point(225, 13);
            this.pYearComboBox.Name = "pYearComboBox";
            this.pYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.pYearComboBox.TabIndex = 9;
            // 
            // driverIDTextBox
            // 
            this.driverIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCarsBindingSource, "DriverID", true));
            this.driverIDTextBox.Location = new System.Drawing.Point(235, 40);
            this.driverIDTextBox.Name = "driverIDTextBox";
            this.driverIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.driverIDTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "search cars";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tDriversBindingSource;
            this.comboBox1.DisplayMember = "DriverID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(461, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "DriverID";
            // 
            // tDriversBindingSource
            // 
            this.tDriversBindingSource.DataMember = "TDrivers";
            this.tDriversBindingSource.DataSource = this.department_of_TransportationDataSet4;
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "נהג";
            chartArea1.AxisY.Title = "מס\' מכוניות";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.שאילתה1BindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(360, 311);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "cars";
            series1.XValueMember = "DriverID";
            series1.YValueMembers = "cars";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(429, 204);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "מכוניות";
            this.chart1.Titles.Add(title1);
            // 
            // שאילתה1BindingSource
            // 
            this.שאילתה1BindingSource.DataMember = "שאילתה1";
            this.שאילתה1BindingSource.DataSource = this.department_of_TransportationDataSet4;
            // 
            // שאילתה1TableAdapter
            // 
            this.שאילתה1TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "show diagram";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.שאילתה2BindingSource;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(24, 364);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "pYear";
            series2.YValueMembers = "amount";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(322, 300);
            this.chart2.TabIndex = 16;
            this.chart2.Text = "chart2";
            // 
            // שאילתה2BindingSource
            // 
            this.שאילתה2BindingSource.DataMember = "שאילתה2";
            this.שאילתה2BindingSource.DataSource = this.department_of_TransportationDataSet4;
            // 
            // שאילתה2TableAdapter
            // 
            this.שאילתה2TableAdapter.ClearBeforeFill = true;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1061, 741);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(driverIDLabel);
            this.Controls.Add(this.driverIDTextBox);
            this.Controls.Add(pYearLabel);
            this.Controls.Add(this.pYearComboBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(numCarLabel);
            this.Controls.Add(this.numCarTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tCarsDataGridView);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.department_of_TransportationDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCarsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDriversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.שאילתה1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.שאילתה2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Department_of_TransportationDataSet4 department_of_TransportationDataSet4;
        private System.Windows.Forms.BindingSource tCarsBindingSource;
        private Department_of_TransportationDataSet4TableAdapters.TCarsTableAdapter tCarsTableAdapter;
        private Department_of_TransportationDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tCarsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox numCarTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox pYearComboBox;
        private System.Windows.Forms.TextBox driverIDTextBox;
        private System.Windows.Forms.Button button1;
        private Department_of_TransportationDataSet4TableAdapters.TDriversTableAdapter tDriversTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tDriversBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource שאילתה1BindingSource;
        private Department_of_TransportationDataSet4TableAdapters.שאילתה1TableAdapter שאילתה1TableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource שאילתה2BindingSource;
        private Department_of_TransportationDataSet4TableAdapters.שאילתה2TableAdapter שאילתה2TableAdapter;
    }
}