namespace WeatherUI.Forms
{
    partial class EditApiKeyForm
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
            if (disposing && (components != null)) {
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
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTimezoneApiKey = new System.Windows.Forms.Button();
            this.txtTimezoneApiKey = new System.Windows.Forms.TextBox();
            this.lblTimezoneApiKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApiKey.Location = new System.Drawing.Point(102, 9);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(178, 30);
            this.lblApiKey.TabIndex = 0;
            this.lblApiKey.Text = "Locations API Key";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApiKey.Location = new System.Drawing.Point(12, 43);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(360, 35);
            this.txtApiKey.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(12, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(360, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Locations API key";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(12, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(360, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTimezoneApiKey
            // 
            this.btnSaveTimezoneApiKey.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveTimezoneApiKey.Location = new System.Drawing.Point(12, 214);
            this.btnSaveTimezoneApiKey.Name = "btnSaveTimezoneApiKey";
            this.btnSaveTimezoneApiKey.Size = new System.Drawing.Size(360, 40);
            this.btnSaveTimezoneApiKey.TabIndex = 4;
            this.btnSaveTimezoneApiKey.Text = "Save Timezone API key";
            this.btnSaveTimezoneApiKey.UseVisualStyleBackColor = true;
            this.btnSaveTimezoneApiKey.Click += new System.EventHandler(this.btnSaveTimezoneApiKey_Click);
            // 
            // txtTimezoneApiKey
            // 
            this.txtTimezoneApiKey.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimezoneApiKey.Location = new System.Drawing.Point(12, 173);
            this.txtTimezoneApiKey.Name = "txtTimezoneApiKey";
            this.txtTimezoneApiKey.Size = new System.Drawing.Size(360, 35);
            this.txtTimezoneApiKey.TabIndex = 3;
            // 
            // lblTimezoneApiKey
            // 
            this.lblTimezoneApiKey.AutoSize = true;
            this.lblTimezoneApiKey.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimezoneApiKey.Location = new System.Drawing.Point(102, 140);
            this.lblTimezoneApiKey.Name = "lblTimezoneApiKey";
            this.lblTimezoneApiKey.Size = new System.Drawing.Size(180, 30);
            this.lblTimezoneApiKey.TabIndex = 4;
            this.lblTimezoneApiKey.Text = "Timezone API Key";
            // 
            // EditApiKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnSaveTimezoneApiKey);
            this.Controls.Add(this.txtTimezoneApiKey);
            this.Controls.Add(this.lblTimezoneApiKey);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.lblApiKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditApiKeyForm";
            this.Text = "Edis API keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveTimezoneApiKey;
        private System.Windows.Forms.TextBox txtTimezoneApiKey;
        private System.Windows.Forms.Label lblTimezoneApiKey;
    }
}