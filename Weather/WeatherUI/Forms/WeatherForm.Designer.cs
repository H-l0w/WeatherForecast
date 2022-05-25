
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
            this.components = new System.ComponentModel.Container();
            this.lblLocationDetails = new System.Windows.Forms.Label();
            this.btnApplicationSettings = new System.Windows.Forms.Button();
            this.btnAddNewLocation = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblLocationInfo = new System.Windows.Forms.Label();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnNextPreviousToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.listLocation = new System.Windows.Forms.ListBox();
            this.lblLocations = new System.Windows.Forms.Label();
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
            this.btnApplicationSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApplicationSettings.Location = new System.Drawing.Point(826, 55);
            this.btnApplicationSettings.Name = "btnApplicationSettings";
            this.btnApplicationSettings.Size = new System.Drawing.Size(200, 40);
            this.btnApplicationSettings.TabIndex = 1;
            this.btnApplicationSettings.Text = "Settings";
            this.btnApplicationSettings.UseVisualStyleBackColor = true;
            this.btnApplicationSettings.Click += new System.EventHandler(this.btnApplicationSettings_Click);
            // 
            // btnAddNewLocation
            // 
            this.btnAddNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewLocation.Location = new System.Drawing.Point(826, 9);
            this.btnAddNewLocation.Name = "btnAddNewLocation";
            this.btnAddNewLocation.Size = new System.Drawing.Size(200, 40);
            this.btnAddNewLocation.TabIndex = 2;
            this.btnAddNewLocation.Text = "Add new location";
            this.btnAddNewLocation.UseVisualStyleBackColor = true;
            this.btnAddNewLocation.Click += new System.EventHandler(this.btnAddNewLocation_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(826, 484);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(200, 70);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next location";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(12, 484);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(200, 70);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous location";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblLocationInfo
            // 
            this.lblLocationInfo.AutoSize = true;
            this.lblLocationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocationInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocationInfo.Location = new System.Drawing.Point(12, 66);
            this.lblLocationInfo.Name = "lblLocationInfo";
            this.lblLocationInfo.Size = new System.Drawing.Size(104, 23);
            this.lblLocationInfo.TabIndex = 5;
            this.lblLocationInfo.Text = "Lorem ipsum";
            // 
            // btnChangeData
            // 
            this.btnChangeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeData.Location = new System.Drawing.Point(620, 484);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(200, 70);
            this.btnChangeData.TabIndex = 12;
            this.btnChangeData.Text = "Change data";
            this.btnChangeData.UseVisualStyleBackColor = true;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(275, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(423, 30);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Temperature for location: locationtime: xx:xx";
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousDay.Location = new System.Drawing.Point(12, 406);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(200, 70);
            this.btnPreviousDay.TabIndex = 16;
            this.btnPreviousDay.Text = "Previous day";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            this.btnPreviousDay.Click += new System.EventHandler(this.bntPreviousDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextDay.Location = new System.Drawing.Point(826, 406);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(200, 70);
            this.btnNextDay.TabIndex = 15;
            this.btnNextDay.Text = "Next day";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // listLocation
            // 
            this.listLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLocation.FormattingEnabled = true;
            this.listLocation.ItemHeight = 25;
            this.listLocation.Location = new System.Drawing.Point(826, 132);
            this.listLocation.Name = "listLocation";
            this.listLocation.Size = new System.Drawing.Size(200, 254);
            this.listLocation.TabIndex = 17;
            this.listLocation.SelectedIndexChanged += new System.EventHandler(this.listLocation_SelectedIndexChanged);
            // 
            // lblLocations
            // 
            this.lblLocations.AutoSize = true;
            this.lblLocations.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocations.Location = new System.Drawing.Point(826, 102);
            this.lblLocations.Name = "lblLocations";
            this.lblLocations.Size = new System.Drawing.Size(101, 30);
            this.lblLocations.TabIndex = 18;
            this.lblLocations.Text = "Locations";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.lblLocations);
            this.Controls.Add(this.listLocation);
            this.Controls.Add(this.btnPreviousDay);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.lblLocationInfo);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddNewLocation);
            this.Controls.Add(this.btnApplicationSettings);
            this.Controls.Add(this.lblLocationDetails);
            this.Name = "WeatherForm";
            this.Text = "WeatherForm";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WeatherForm_KeyDown);
            this.Resize += new System.EventHandler(this.WeatherForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocationDetails;
        private System.Windows.Forms.Button btnApplicationSettings;
        private System.Windows.Forms.Button btnAddNewLocation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblLocationInfo;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.ToolTip btnNextPreviousToolTip;
        private System.Windows.Forms.ListBox listLocation;
        private System.Windows.Forms.Label lblLocations;
    }
}