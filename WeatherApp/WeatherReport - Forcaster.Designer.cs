namespace WeatherApp
{
    partial class WeatherReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.radOne = new System.Windows.Forms.RadioButton();
            this.radMultiple = new System.Windows.Forms.RadioButton();
            this.cmbCity2 = new System.Windows.Forms.ComboBox();
            this.lablCity2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClearLb = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Location = new System.Drawing.Point(423, 95);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(79, 13);
            this.lblFavorite.TabIndex = 68;
            this.lblFavorite.Text = "Favorite Cities?";
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Location = new System.Drawing.Point(636, 537);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(110, 23);
            this.btnSaveReport.TabIndex = 67;
            this.btnSaveReport.Text = "Save Report";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(362, 55);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(208, 30);
            this.lblHeading.TabIndex = 66;
            this.lblHeading.Text = "Weather App";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.city,
            this.date,
            this.minTemp,
            this.maxTamp,
            this.prec,
            this.hum,
            this.wind});
            this.dataGridView1.Location = new System.Drawing.Point(97, 284);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(744, 231);
            this.dataGridView1.TabIndex = 65;
            // 
            // city
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.DefaultCellStyle = dataGridViewCellStyle2;
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // date
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.DefaultCellStyle = dataGridViewCellStyle3;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // minTemp
            // 
            this.minTemp.HeaderText = "Min Temp";
            this.minTemp.Name = "minTemp";
            this.minTemp.ReadOnly = true;
            // 
            // maxTamp
            // 
            this.maxTamp.HeaderText = "Max Temp";
            this.maxTamp.Name = "maxTamp";
            this.maxTamp.ReadOnly = true;
            // 
            // prec
            // 
            this.prec.HeaderText = "Precipitation";
            this.prec.Name = "prec";
            this.prec.ReadOnly = true;
            // 
            // hum
            // 
            this.hum.HeaderText = "Humidity";
            this.hum.Name = "hum";
            this.hum.ReadOnly = true;
            // 
            // wind
            // 
            this.wind.HeaderText = "Wind Speed";
            this.wind.Name = "wind";
            this.wind.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 537);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 23);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add Weather";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radOne
            // 
            this.radOne.AutoSize = true;
            this.radOne.Location = new System.Drawing.Point(252, 217);
            this.radOne.Name = "radOne";
            this.radOne.Size = new System.Drawing.Size(100, 17);
            this.radOne.TabIndex = 63;
            this.radOne.TabStop = true;
            this.radOne.Text = "One City Report";
            this.radOne.UseVisualStyleBackColor = true;
            this.radOne.CheckedChanged += new System.EventHandler(this.radOne_CheckedChanged);
            // 
            // radMultiple
            // 
            this.radMultiple.AutoSize = true;
            this.radMultiple.Location = new System.Drawing.Point(252, 245);
            this.radMultiple.Name = "radMultiple";
            this.radMultiple.Size = new System.Drawing.Size(116, 17);
            this.radMultiple.TabIndex = 62;
            this.radMultiple.TabStop = true;
            this.radMultiple.Text = "Multiple City Report";
            this.radMultiple.UseVisualStyleBackColor = true;
            this.radMultiple.CheckedChanged += new System.EventHandler(this.radMultiple_CheckedChanged);
            // 
            // cmbCity2
            // 
            this.cmbCity2.FormattingEnabled = true;
            this.cmbCity2.Location = new System.Drawing.Point(522, 244);
            this.cmbCity2.Name = "cmbCity2";
            this.cmbCity2.Size = new System.Drawing.Size(121, 21);
            this.cmbCity2.TabIndex = 61;
            this.cmbCity2.Visible = false;
            // 
            // lablCity2
            // 
            this.lablCity2.AutoSize = true;
            this.lablCity2.Location = new System.Drawing.Point(472, 252);
            this.lablCity2.Name = "lablCity2";
            this.lablCity2.Size = new System.Drawing.Size(30, 13);
            this.lablCity2.TabIndex = 60;
            this.lablCity2.Text = "City2";
            this.lablCity2.Visible = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(488, 537);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(110, 23);
            this.btnDisplay.TabIndex = 59;
            this.btnDisplay.Text = "Display Forcast";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClearLb
            // 
            this.btnClearLb.Location = new System.Drawing.Point(333, 537);
            this.btnClearLb.Name = "btnClearLb";
            this.btnClearLb.Size = new System.Drawing.Size(117, 23);
            this.btnClearLb.TabIndex = 58;
            this.btnClearLb.Text = "Clear";
            this.btnClearLb.UseVisualStyleBackColor = true;
            this.btnClearLb.Click += new System.EventHandler(this.btnClearLb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "To Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "From Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "City";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(475, 176);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 54;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(522, 213);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 53;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(252, 176);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 52;
            // 
            // WeatherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 603);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radOne);
            this.Controls.Add(this.radMultiple);
            this.Controls.Add(this.cmbCity2);
            this.Controls.Add(this.lablCity2);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnClearLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.dtpFrom);
            this.Name = "WeatherReport";
            this.Text = "WeatherReport";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radOne;
        private System.Windows.Forms.RadioButton radMultiple;
        private System.Windows.Forms.ComboBox cmbCity2;
        private System.Windows.Forms.Label lablCity2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClearLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn hum;
        private System.Windows.Forms.DataGridViewTextBoxColumn wind;
    }
}