namespace WeatherUI.Forms
{
    partial class ApplicationSettingsForm
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
            this.bntChangeTheme = new System.Windows.Forms.Button();
            this.btnEditApiKey = new System.Windows.Forms.Button();
            this.btnEditSavedLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntChangeTheme
            // 
            this.bntChangeTheme.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntChangeTheme.Location = new System.Drawing.Point(12, 10);
            this.bntChangeTheme.Name = "bntChangeTheme";
            this.bntChangeTheme.Size = new System.Drawing.Size(260, 40);
            this.bntChangeTheme.TabIndex = 0;
            this.bntChangeTheme.Text = "Edit color theme";
            this.bntChangeTheme.UseVisualStyleBackColor = true;
            this.bntChangeTheme.Click += new System.EventHandler(this.bntChangeTheme_Click);
            // 
            // btnEditApiKey
            // 
            this.btnEditApiKey.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditApiKey.Location = new System.Drawing.Point(12, 80);
            this.btnEditApiKey.Name = "btnEditApiKey";
            this.btnEditApiKey.Size = new System.Drawing.Size(260, 40);
            this.btnEditApiKey.TabIndex = 1;
            this.btnEditApiKey.Text = "Edit API key";
            this.btnEditApiKey.UseVisualStyleBackColor = true;
            this.btnEditApiKey.Click += new System.EventHandler(this.btnEditApiKey_Click);
            // 
            // btnEditSavedLocation
            // 
            this.btnEditSavedLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSavedLocation.Location = new System.Drawing.Point(12, 150);
            this.btnEditSavedLocation.Name = "btnEditSavedLocation";
            this.btnEditSavedLocation.Size = new System.Drawing.Size(260, 40);
            this.btnEditSavedLocation.TabIndex = 2;
            this.btnEditSavedLocation.Text = "Edit saved locations";
            this.btnEditSavedLocation.UseVisualStyleBackColor = true;
            this.btnEditSavedLocation.Click += new System.EventHandler(this.btnEditSavedLocation_Click);
            // 
            // ApplicationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.btnEditSavedLocation);
            this.Controls.Add(this.btnEditApiKey);
            this.Controls.Add(this.bntChangeTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationSettingsForm";
            this.Text = "ApplicationSettingsForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ApplicationSettingsForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntChangeTheme;
        private System.Windows.Forms.Button btnEditApiKey;
        private System.Windows.Forms.Button btnEditSavedLocation;
    }
}