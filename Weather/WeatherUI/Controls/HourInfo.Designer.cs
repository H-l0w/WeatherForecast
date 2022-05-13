
namespace WeatherUI.Controls
{
    partial class HourInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctIcon = new System.Windows.Forms.PictureBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pctIcon
            // 
            this.pctIcon.Location = new System.Drawing.Point(3, 3);
            this.pctIcon.Name = "pctIcon";
            this.pctIcon.Size = new System.Drawing.Size(68, 68);
            this.pctIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctIcon.TabIndex = 0;
            this.pctIcon.TabStop = false;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValue.Location = new System.Drawing.Point(77, 41);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(60, 30);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "xx °C";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(77, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 30);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "xx:xx";
            // 
            // HourInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.pctIcon);
            this.Name = "HourInfo";
            this.Size = new System.Drawing.Size(150, 76);
            this.Load += new System.EventHandler(this.HourInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctIcon;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblTime;
    }
}
