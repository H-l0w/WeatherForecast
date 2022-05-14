
namespace WeatherUI.Forms
{
    partial class WeatherForm
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
            this.lblLocationDetails = new System.Windows.Forms.Label();
            this.btnApplicationSettings = new System.Windows.Forms.Button();
            this.btnAddNewLocation = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.LblLongitude = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblContinent = new System.Windows.Forms.Label();
            this.lblElevation = new System.Windows.Forms.Label();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnSavedLocations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocationDetails
            // 
            this.lblLocationDetails.AutoSize = true;
            this.lblLocationDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocationDetails.Location = new System.Drawing.Point(12, 9);
            this.lblLocationDetails.Name = "lblLocationDetails";
            this.lblLocationDetails.Size = new System.Drawing.Size(257, 30);
            this.lblLocationDetails.TabIndex = 0;
            this.lblLocationDetails.Text = "Location details - Location";
            // 
            // btnApplicationSettings
            // 
            this.btnApplicationSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApplicationSettings.Location = new System.Drawing.Point(809, 55);
            this.btnApplicationSettings.Name = "btnApplicationSettings";
            this.btnApplicationSettings.Size = new System.Drawing.Size(213, 40);
            this.btnApplicationSettings.TabIndex = 1;
            this.btnApplicationSettings.Text = "Application settings";
            this.btnApplicationSettings.UseVisualStyleBackColor = true;
            this.btnApplicationSettings.Click += new System.EventHandler(this.btnApplicationSettings_Click);
            // 
            // btnAddNewLocation
            // 
            this.btnAddNewLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewLocation.Location = new System.Drawing.Point(809, 9);
            this.btnAddNewLocation.Name = "btnAddNewLocation";
            this.btnAddNewLocation.Size = new System.Drawing.Size(213, 40);
            this.btnAddNewLocation.TabIndex = 2;
            this.btnAddNewLocation.Text = "Add new location";
            this.btnAddNewLocation.UseVisualStyleBackColor = true;
            this.btnAddNewLocation.Click += new System.EventHandler(this.btnAddNewLocation_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(906, 484);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 72);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next\r\nlocation";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(12, 484);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(116, 72);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous\r\nlocation";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLatitude.Location = new System.Drawing.Point(12, 39);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(102, 21);
            this.lblLatitude.TabIndex = 5;
            this.lblLatitude.Text = "Lorem ipsum";
            // 
            // LblLongitude
            // 
            this.LblLongitude.AutoSize = true;
            this.LblLongitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLongitude.Location = new System.Drawing.Point(12, 60);
            this.LblLongitude.Name = "LblLongitude";
            this.LblLongitude.Size = new System.Drawing.Size(102, 21);
            this.LblLongitude.TabIndex = 6;
            this.LblLongitude.Text = "Lorem ipsum";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.Location = new System.Drawing.Point(12, 102);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(102, 21);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Lorem ipsum";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegion.Location = new System.Drawing.Point(12, 81);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(102, 21);
            this.lblRegion.TabIndex = 9;
            this.lblRegion.Text = "Lorem ipsum";
            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContinent.Location = new System.Drawing.Point(12, 123);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(102, 21);
            this.lblContinent.TabIndex = 10;
            this.lblContinent.Text = "Lorem ipsum";
            // 
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblElevation.Location = new System.Drawing.Point(12, 144);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(102, 21);
            this.lblElevation.TabIndex = 11;
            this.lblElevation.Text = "Lorem ipsum";
            // 
            // btnChangeData
            // 
            this.btnChangeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeData.Location = new System.Drawing.Point(742, 484);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(150, 72);
            this.btnChangeData.TabIndex = 12;
            this.btnChangeData.Text = "Change\r\nData";
            this.btnChangeData.UseVisualStyleBackColor = true;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(155, 145);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(423, 30);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Temperature for location: locationtime: xx:xx";
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousDay.Location = new System.Drawing.Point(12, 406);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(116, 72);
            this.btnPreviousDay.TabIndex = 16;
            this.btnPreviousDay.Text = "Previous\r\nday";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            this.btnPreviousDay.Click += new System.EventHandler(this.bntPreviousDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextDay.Location = new System.Drawing.Point(906, 406);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(116, 72);
            this.btnNextDay.TabIndex = 15;
            this.btnNextDay.Text = "Next\r\nday";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // btnSavedLocations
            // 
            this.btnSavedLocations.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSavedLocations.Location = new System.Drawing.Point(809, 101);
            this.btnSavedLocations.Name = "btnSavedLocations";
            this.btnSavedLocations.Size = new System.Drawing.Size(213, 40);
            this.btnSavedLocations.TabIndex = 17;
            this.btnSavedLocations.Text = "Saved locations";
            this.btnSavedLocations.UseVisualStyleBackColor = true;
            this.btnSavedLocations.Click += new System.EventHandler(this.btnSavedLocationsManager_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.btnSavedLocations);
            this.Controls.Add(this.btnPreviousDay);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.lblElevation);
            this.Controls.Add(this.lblContinent);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.LblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddNewLocation);
            this.Controls.Add(this.btnApplicationSettings);
            this.Controls.Add(this.lblLocationDetails);
            this.Name = "WeatherForm";
            this.Text = "WeatherForm";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocationDetails;
        private System.Windows.Forms.Button btnApplicationSettings;
        private System.Windows.Forms.Button btnAddNewLocation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label LblLongitude;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.Button btnSavedLocations;
    }
}