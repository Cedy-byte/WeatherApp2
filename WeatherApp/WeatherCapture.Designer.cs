namespace WeatherApp
{
    partial class WeatherCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherCapture));
            this.numUpDwnWind = new System.Windows.Forms.NumericUpDown();
            this.lblcap = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHum = new System.Windows.Forms.Label();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.lblPrec = new System.Windows.Forms.Label();
            this.numUpDwnHum = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnHum)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDwnWind
            // 
            this.numUpDwnWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDwnWind.Location = new System.Drawing.Point(153, 402);
            this.numUpDwnWind.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDwnWind.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUpDwnWind.Name = "numUpDwnWind";
            this.numUpDwnWind.Size = new System.Drawing.Size(256, 24);
            this.numUpDwnWind.TabIndex = 73;
            // 
            // lblcap
            // 
            this.lblcap.AutoSize = true;
            this.lblcap.BackColor = System.Drawing.Color.Transparent;
            this.lblcap.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcap.Location = new System.Drawing.Point(264, 55);
            this.lblcap.Name = "lblcap";
            this.lblcap.Size = new System.Drawing.Size(278, 30);
            this.lblcap.TabIndex = 72;
            this.lblcap.Text = "Weather Capture";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(693, 463);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 31);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(607, 463);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 31);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lstCities
            // 
            this.lstCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 16;
            this.lstCities.Location = new System.Drawing.Point(521, 210);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(243, 228);
            this.lstCities.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 68;
            this.label4.Text = "Captured Weather";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(36, 291);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(86, 20);
            this.lblMaxTemp.TabIndex = 67;
            this.lblMaxTemp.Text = "Max Temp:";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(36, 257);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(85, 20);
            this.lblMinTemp.TabIndex = 66;
            this.lblMinTemp.Text = "Miin Temp:";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTemp.Location = new System.Drawing.Point(153, 285);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(256, 24);
            this.txtMaxTemp.TabIndex = 65;
            this.txtMaxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTemp_KeyPress);
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinTemp.Location = new System.Drawing.Point(153, 251);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(256, 24);
            this.txtMinTemp.TabIndex = 64;
            this.txtMinTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinTemp_KeyPress);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(36, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 63;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(153, 172);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(256, 24);
            this.txtCity.TabIndex = 62;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(36, 217);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 61;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(153, 212);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(256, 24);
            this.dtpDate.TabIndex = 60;
            this.dtpDate.Value = new System.DateTime(2020, 7, 18, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(287, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 29);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(153, 463);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(122, 29);
            this.btnView.TabIndex = 58;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.Location = new System.Drawing.Point(36, 408);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(100, 20);
            this.lblWind.TabIndex = 57;
            this.lblWind.Text = "Wind Speed:";
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHum.Location = new System.Drawing.Point(36, 367);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(74, 20);
            this.lblHum.TabIndex = 54;
            this.lblHum.Text = "Humidity:";
            // 
            // txtPrec
            // 
            this.txtPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrec.Location = new System.Drawing.Point(153, 318);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(256, 24);
            this.txtPrec.TabIndex = 53;
            this.txtPrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrec_KeyPress);
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrec.Location = new System.Drawing.Point(36, 324);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(100, 20);
            this.lblPrec.TabIndex = 52;
            this.lblPrec.Text = "Precipitation:";
            // 
            // numUpDwnHum
            // 
            this.numUpDwnHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDwnHum.Location = new System.Drawing.Point(153, 361);
            this.numUpDwnHum.Name = "numUpDwnHum";
            this.numUpDwnHum.Size = new System.Drawing.Size(256, 24);
            this.numUpDwnHum.TabIndex = 74;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(521, 463);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 31);
            this.btnReset.TabIndex = 75;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // WeatherCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 541);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.numUpDwnHum);
            this.Controls.Add(this.numUpDwnWind);
            this.Controls.Add(this.lblcap);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstCities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.txtMaxTemp);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblHum);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.lblPrec);
            this.DoubleBuffered = true;
            this.Name = "WeatherCapture";
            this.Text = "WeatherCapture";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnHum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDwnWind;
        private System.Windows.Forms.Label lblcap;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.NumericUpDown numUpDwnHum;
        private System.Windows.Forms.Button btnReset;
    }
}

