using System;
using System.IO;
using WeatherLibrary.Helpers;

namespace WeatherUI.Forms
{
    public partial class EditApiKeyForm : FormBase
    {
        public EditApiKeyForm()
        {
            InitializeComponent();
            txtApiKey.Text = SessionHelper.Instance.ApiKeyLocations;
            txtTimezoneApiKey.Text = SessionHelper.Instance.ApiKeyTimeZone;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            SessionHelper.Instance.ApiKeyLocations = txtApiKey.Text;
            ConfigHelper.Instance.EditConfig(Path.Combine(ConfigHelper.Instance.dirName, ConfigHelper.Instance.appSettingsFile), "API Key - Locations", "API Key - Locations: " + "\"" + txtApiKey.Text + "\"");
        }

        private void btnSaveTimezoneApiKey_Click(object sender, EventArgs e)
        {
            SessionHelper.Instance.ApiKeyTimeZone = txtTimezoneApiKey.Text;
            ConfigHelper.Instance.EditConfig(Path.Combine(ConfigHelper.Instance.dirName, ConfigHelper.Instance.appSettingsFile), "API Key - Timezone", "API Key - Timezone: " +"\"" + txtTimezoneApiKey.Text + "\"");
        }
    }
}
