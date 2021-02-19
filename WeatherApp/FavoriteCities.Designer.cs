namespace WeatherApp
{
    partial class FavoriteCities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteCities));
            this.lblcap = new System.Windows.Forms.Label();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstFavCities = new System.Windows.Forms.ListBox();
            this.lblblFavorites = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcap
            // 
            this.lblcap.AutoSize = true;
            this.lblcap.BackColor = System.Drawing.Color.Transparent;
            this.lblcap.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcap.Location = new System.Drawing.Point(246, 43);
            this.lblcap.Name = "lblcap";
            this.lblcap.Size = new System.Drawing.Size(227, 30);
            this.lblcap.TabIndex = 73;
            this.lblcap.Text = "Add Favorites";
            // 
            // lstCities
            // 
            this.lstCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 16;
            this.lstCities.Location = new System.Drawing.Point(34, 177);
            this.lstCities.Name = "lstCities";
            this.lstCities.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCities.Size = new System.Drawing.Size(243, 228);
            this.lstCities.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 75;
            this.label4.Text = "Available Cities";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(160, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 34);
            this.btnAdd.TabIndex = 76;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(519, 431);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 34);
            this.btnRemove.TabIndex = 77;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstFavCities
            // 
            this.lstFavCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFavCities.FormattingEnabled = true;
            this.lstFavCities.ItemHeight = 16;
            this.lstFavCities.Location = new System.Drawing.Point(463, 177);
            this.lstFavCities.Name = "lstFavCities";
            this.lstFavCities.Size = new System.Drawing.Size(236, 228);
            this.lstFavCities.TabIndex = 78;
            // 
            // lblblFavorites
            // 
            this.lblblFavorites.AutoSize = true;
            this.lblblFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblFavorites.Location = new System.Drawing.Point(515, 132);
            this.lblblFavorites.Name = "lblblFavorites";
            this.lblblFavorites.Size = new System.Drawing.Size(127, 24);
            this.lblblFavorites.TabIndex = 79;
            this.lblblFavorites.Text = "Favorite Cities";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(56, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 34);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FavoriteCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 506);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblblFavorites);
            this.Controls.Add(this.lstFavCities);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstCities);
            this.Controls.Add(this.lblcap);
            this.DoubleBuffered = true;
            this.Name = "FavoriteCities";
            this.Text = "FavoriteCities";
            this.Load += new System.EventHandler(this.FavoriteCities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcap;
        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstFavCities;
        private System.Windows.Forms.Label lblblFavorites;
        private System.Windows.Forms.Button btnBack;
    }
}