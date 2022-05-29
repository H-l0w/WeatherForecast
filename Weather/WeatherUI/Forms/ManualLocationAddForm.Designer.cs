namespace WeatherUI.Forms
{
    partial class ManualLocationAddForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.numTimeOffset = new System.Windows.Forms.NumericUpDown();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblContinent = new System.Windows.Forms.Label();
            this.txtContinent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkIsTimeOffset = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(12, 522);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(205, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add new location";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLatitude.Location = new System.Drawing.Point(12, 42);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.PlaceholderText = "Enter latitude";
            this.txtLatitude.Size = new System.Drawing.Size(205, 35);
            this.txtLatitude.TabIndex = 1;
            this.txtLatitude.Validating += new System.ComponentModel.CancelEventHandler(this.txtLatitude_Validating);
            // 
            // numTimeOffset
            // 
            this.numTimeOffset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTimeOffset.Location = new System.Drawing.Point(135, 481);
            this.numTimeOffset.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numTimeOffset.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
            this.numTimeOffset.Name = "numTimeOffset";
            this.numTimeOffset.Size = new System.Drawing.Size(60, 35);
            this.numTimeOffset.TabIndex = 8;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLatitude.Location = new System.Drawing.Point(12, 9);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(88, 30);
            this.lblLatitude.TabIndex = 7;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLongitude.Location = new System.Drawing.Point(12, 80);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(106, 30);
            this.lblLongitude.TabIndex = 9;
            this.lblLongitude.Text = "Longitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLongitude.Location = new System.Drawing.Point(12, 113);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.PlaceholderText = "Enter Longitude";
            this.txtLongitude.Size = new System.Drawing.Size(205, 35);
            this.txtLongitude.TabIndex = 2;
            this.txtLongitude.Validating += new System.ComponentModel.CancelEventHandler(this.txtLongitude_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 151);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 30);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(12, 184);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Search for location";
            this.txtName.Size = new System.Drawing.Size(205, 35);
            this.txtName.TabIndex = 3;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegion.Location = new System.Drawing.Point(12, 222);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(77, 30);
            this.lblRegion.TabIndex = 13;
            this.lblRegion.Text = "Region";
            // 
            // txtRegion
            // 
            this.txtRegion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegion.Location = new System.Drawing.Point(12, 255);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.PlaceholderText = "Enter region";
            this.txtRegion.Size = new System.Drawing.Size(205, 35);
            this.txtRegion.TabIndex = 4;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.Location = new System.Drawing.Point(12, 293);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(86, 30);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(12, 326);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "Enter country";
            this.txtCountry.Size = new System.Drawing.Size(205, 35);
            this.txtCountry.TabIndex = 5;
            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContinent.Location = new System.Drawing.Point(12, 364);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(104, 30);
            this.lblContinent.TabIndex = 17;
            this.lblContinent.Text = "Continent";
            // 
            // txtContinent
            // 
            this.txtContinent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContinent.Location = new System.Drawing.Point(12, 397);
            this.txtContinent.Name = "txtContinent";
            this.txtContinent.PlaceholderText = "Enter continent";
            this.txtContinent.Size = new System.Drawing.Size(205, 35);
            this.txtContinent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Time offset";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(12, 563);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(205, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHour.Location = new System.Drawing.Point(197, 483);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(25, 30);
            this.lblHour.TabIndex = 20;
            this.lblHour.Text = "h";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // checkIsTimeOffset
            // 
            this.checkIsTimeOffset.AutoSize = true;
            this.checkIsTimeOffset.Checked = true;
            this.checkIsTimeOffset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIsTimeOffset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkIsTimeOffset.Location = new System.Drawing.Point(12, 441);
            this.checkIsTimeOffset.Name = "checkIsTimeOffset";
            this.checkIsTimeOffset.Size = new System.Drawing.Size(167, 34);
            this.checkIsTimeOffset.TabIndex = 7;
            this.checkIsTimeOffset.Text = "Set time offset";
            this.checkIsTimeOffset.UseVisualStyleBackColor = true;
            this.checkIsTimeOffset.CheckedChanged += new System.EventHandler(this.checkIsTimeOffset_CheckedChanged);
            // 
            // ManualLocationAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 612);
            this.Controls.Add(this.checkIsTimeOffset);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContinent);
            this.Controls.Add(this.txtContinent);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.numTimeOffset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLatitude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualLocationAddForm";
            this.Text = "Add location manually";
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.NumericUpDown numTimeOffset;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.TextBox txtContinent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkIsTimeOffset;
    }
}