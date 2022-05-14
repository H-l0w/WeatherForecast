﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WeatherLibrary.Helpers;

namespace WeatherUI.Forms
{
    public partial class ApplicationSettingsForm : FormBase
    {
        public ApplicationSettingsForm()
        {
            InitializeComponent();
        }

        private void bntChangeTheme_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                ConfigHelper.Instance.AddColorTheme(colorDialog.Color);
                SessionHelper.Instance.Background = colorDialog.Color;
                foreach (Form form in Application.OpenForms)
                {
                    form.BackColor = colorDialog.Color;
                }
            }
        }

        private void btnEditApiKey_Click(object sender, EventArgs e)
        {
            EditApiKeyForm form = new EditApiKeyForm();
            form.ShowDialog();
        }

        private void btnEditSavedLocation_Click(object sender, EventArgs e)
        {
            SavedLocationsForm form = new SavedLocationsForm();
            form.Show();
        }

        private void ApplicationSettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}