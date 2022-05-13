
namespace WeatherUI.Forms
{
    partial class ChangeDataForm
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
            this.cmbData = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbData
            // 
            this.cmbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbData.FormattingEnabled = true;
            this.cmbData.Items.AddRange(new object[] {
            "Temperature",
            "Apperent temperature",
            "Precipitation",
            "Cloud cover",
            "Wind speed",
            "Snow height",
            "Dewpoint",
            "Relative humidity"});
            this.cmbData.Location = new System.Drawing.Point(12, 9);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(210, 38);
            this.cmbData.TabIndex = 0;
            this.cmbData.SelectedIndexChanged += new System.EventHandler(this.cmbData_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(12, 214);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(210, 35);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ChangeDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbData);
            this.Name = "ChangeDataForm";
            this.Text = "ChangeDataForm";
            this.Load += new System.EventHandler(this.ChangeDataForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbData;
        private System.Windows.Forms.Button btnConfirm;
    }
}