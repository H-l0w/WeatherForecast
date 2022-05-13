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
            this.SuspendLayout();
            // 
            // bntChangeTheme
            // 
            this.bntChangeTheme.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntChangeTheme.Location = new System.Drawing.Point(12, 12);
            this.bntChangeTheme.Name = "bntChangeTheme";
            this.bntChangeTheme.Size = new System.Drawing.Size(199, 39);
            this.bntChangeTheme.TabIndex = 0;
            this.bntChangeTheme.Text = "Change theme";
            this.bntChangeTheme.UseVisualStyleBackColor = true;
            this.bntChangeTheme.Click += new System.EventHandler(this.bntChangeTheme_Click);
            // 
            // ApplicationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 151);
            this.Controls.Add(this.bntChangeTheme);
            this.Name = "ApplicationSettingsForm";
            this.Text = "ApplicationSettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntChangeTheme;
    }
}