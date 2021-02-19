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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherReport));
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
            this.lblCity2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbFavorite1 = new System.Windows.Forms.ComboBox();
            this.cmbFavorite2 = new System.Windows.Forms.ComboBox();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.BackColor = System.Drawing.Color.Transparent;
            this.lblFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorite.Location = new System.Drawing.Point(651, 174);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(108, 16);
            this.lblFavorite.TabIndex = 68;
            this.lblFavorite.Text = "Favorite Cities";
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReport.Location = new System.Drawing.Point(665, 527);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(122, 40);
            this.btnSaveReport.TabIndex = 67;
            this.btnSaveReport.Text = "Save Report";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(326, 55);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(259, 30);
            this.lblHeading.TabIndex = 66;
            this.lblHeading.Text = "Weather Report";
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
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(153, 527);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 40);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add Weather";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radOne
            // 
            this.radOne.AutoSize = true;
            this.radOne.BackColor = System.Drawing.Color.Transparent;
            this.radOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOne.Location = new System.Drawing.Point(184, 212);
            this.radOne.Name = "radOne";
            this.radOne.Size = new System.Drawing.Size(110, 19);
            this.radOne.TabIndex = 63;
            this.radOne.TabStop = true;
            this.radOne.Text = "One City Report";
            this.radOne.UseVisualStyleBackColor = false;
            this.radOne.CheckedChanged += new System.EventHandler(this.radOne_CheckedChanged);
            // 
            // radMultiple
            // 
            this.radMultiple.AutoSize = true;
            this.radMultiple.BackColor = System.Drawing.Color.Transparent;
            this.radMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiple.Location = new System.Drawing.Point(184, 241);
            this.radMultiple.Name = "radMultiple";
            this.radMultiple.Size = new System.Drawing.Size(131, 19);
            this.radMultiple.TabIndex = 62;
            this.radMultiple.TabStop = true;
            this.radMultiple.Text = "Multiple City Report";
            this.radMultiple.UseVisualStyleBackColor = false;
            this.radMultiple.CheckedChanged += new System.EventHandler(this.radMultiple_CheckedChanged);
            // 
            // cmbCity2
            // 
            this.cmbCity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity2.FormattingEnabled = true;
            this.cmbCity2.Location = new System.Drawing.Point(454, 237);
            this.cmbCity2.Name = "cmbCity2";
            this.cmbCity2.Size = new System.Drawing.Size(121, 23);
            this.cmbCity2.TabIndex = 61;
            this.cmbCity2.Visible = false;
            // 
            // lblCity2
            // 
            this.lblCity2.AutoSize = true;
            this.lblCity2.BackColor = System.Drawing.Color.Transparent;
            this.lblCity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity2.Location = new System.Drawing.Point(404, 245);
            this.lblCity2.Name = "lblCity2";
            this.lblCity2.Size = new System.Drawing.Size(39, 15);
            this.lblCity2.TabIndex = 60;
            this.lblCity2.Text = "City2 :";
            this.lblCity2.Visible = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(409, 527);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(122, 40);
            this.btnDisplay.TabIndex = 59;
            this.btnDisplay.Text = "Display Forcast";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(281, 527);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 40);
            this.btnReset.TabIndex = 58;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "To Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "From Date";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(404, 214);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 15);
            this.lblCity.TabIndex = 55;
            this.lblCity.Text = "City :";
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(407, 169);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 54;
            // 
            // cmbCity
            // 
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(454, 206);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 23);
            this.cmbCity.TabIndex = 53;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(184, 169);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 52;
            // 
            // cmbFavorite1
            // 
            this.cmbFavorite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFavorite1.FormattingEnabled = true;
            this.cmbFavorite1.Location = new System.Drawing.Point(645, 206);
            this.cmbFavorite1.Name = "cmbFavorite1";
            this.cmbFavorite1.Size = new System.Drawing.Size(121, 23);
            this.cmbFavorite1.TabIndex = 69;
            // 
            // cmbFavorite2
            // 
            this.cmbFavorite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFavorite2.FormattingEnabled = true;
            this.cmbFavorite2.Location = new System.Drawing.Point(645, 238);
            this.cmbFavorite2.Name = "cmbFavorite2";
            this.cmbFavorite2.Size = new System.Drawing.Size(121, 23);
            this.cmbFavorite2.TabIndex = 70;
            // 
            // btnFavorites
            // 
            this.btnFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorites.Location = new System.Drawing.Point(537, 527);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(122, 40);
            this.btnFavorites.TabIndex = 71;
            this.btnFavorites.Text = "Add Favorites";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(153, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 40);
            this.btnExit.TabIndex = 72;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WeatherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 603);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.cmbFavorite2);
            this.Controls.Add(this.cmbFavorite1);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radOne);
            this.Controls.Add(this.radMultiple);
            this.Controls.Add(this.cmbCity2);
            this.Controls.Add(this.lblCity2);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.dtpFrom);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label lblCity2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cmbFavorite1;
        private System.Windows.Forms.ComboBox cmbFavorite2;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn hum;
        private System.Windows.Forms.DataGridViewTextBoxColumn wind;
        private System.Windows.Forms.Button btnExit;
    }
}