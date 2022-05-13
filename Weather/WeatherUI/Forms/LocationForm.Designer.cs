
namespace WeatherUI.Forms
{
    partial class LocationForm
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridLocations = new System.Windows.Forms.DataGridView();
            this.checkSaveSelectedLocation = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnApplicationSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocation.Location = new System.Drawing.Point(12, 12);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PlaceholderText = "Search for location";
            this.txtLocation.Size = new System.Drawing.Size(200, 35);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(218, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridLocations
            // 
            this.dataGridLocations.AllowUserToAddRows = false;
            this.dataGridLocations.AllowUserToDeleteRows = false;
            this.dataGridLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocations.Location = new System.Drawing.Point(12, 54);
            this.dataGridLocations.Name = "dataGridLocations";
            this.dataGridLocations.ReadOnly = true;
            this.dataGridLocations.RowHeadersVisible = false;
            this.dataGridLocations.RowTemplate.Height = 25;
            this.dataGridLocations.Size = new System.Drawing.Size(460, 295);
            this.dataGridLocations.TabIndex = 2;
            this.dataGridLocations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLocations_CellDoubleClick);
            // 
            // checkSaveSelectedLocation
            // 
            this.checkSaveSelectedLocation.AutoSize = true;
            this.checkSaveSelectedLocation.Location = new System.Drawing.Point(324, 28);
            this.checkSaveSelectedLocation.Name = "checkSaveSelectedLocation";
            this.checkSaveSelectedLocation.Size = new System.Drawing.Size(142, 19);
            this.checkSaveSelectedLocation.TabIndex = 3;
            this.checkSaveSelectedLocation.Text = "Save selected location";
            this.checkSaveSelectedLocation.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(372, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApplicationSettings
            // 
            this.btnApplicationSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApplicationSettings.Location = new System.Drawing.Point(116, 352);
            this.btnApplicationSettings.Name = "btnApplicationSettings";
            this.btnApplicationSettings.Size = new System.Drawing.Size(250, 35);
            this.btnApplicationSettings.TabIndex = 5;
            this.btnApplicationSettings.Text = "Application settings";
            this.btnApplicationSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApplicationSettings.UseVisualStyleBackColor = true;
            this.btnApplicationSettings.Click += new System.EventHandler(this.btnApplicationSettings_Click);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 399);
            this.Controls.Add(this.btnApplicationSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkSaveSelectedLocation);
            this.Controls.Add(this.dataGridLocations);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLocation);
            this.Name = "LocationForm";
            this.Text = "LocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridLocations;
        private System.Windows.Forms.CheckBox checkSaveSelectedLocation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnApplicationSettings;
    }
}