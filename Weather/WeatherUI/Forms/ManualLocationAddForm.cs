using System.Windows.Forms;
using WeatherLibrary.Objects;

namespace WeatherUI.Forms
{
    public partial class ManualLocationAddForm : FormBase
    {
        public Location NewLocation;
        public ManualLocationAddForm()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            NewLocation = GetLocation();
            this.Close();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private Location GetLocation()
        {
            Location location = new Location();
            location.Name = txtName.Text;
            location.Region = txtRegion.Text;
            location.Country = txtCountry.Text;
            location.Continent = txtContinent.Text;
            location.Latitude = float.Parse(txtLatitude.Text);
            location.Longitude = float.Parse(txtLongitude.Text);
            if (checkIsTimeOffset.Checked) {
                location.IsTimeZoneSet = true;
                location.TimeOffset = (int)numTimeOffset.Value * 3600;
            }
            else
                location.IsTimeZoneSet = Focused;
            return location;
        }

        private void txtLatitude_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLatitude.Text))
                return;

            float temp = 0;
            if (!float.TryParse(txtLatitude.Text, out temp))
                errorProvider.SetError(txtLatitude, "Value must be a number");
            else {
                errorProvider.SetError(txtLatitude, null);
            }
            btnAdd.Enabled = CanBeLocationAdded();
        }

        private void txtLongitude_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLongitude.Text))
                return;

            float temp = 0;
            if (!float.TryParse(txtLongitude.Text, out temp))
                errorProvider.SetError(txtLongitude, "Value must be a number");
            else {
                errorProvider.SetError(txtLongitude, null);
            }
            btnAdd.Enabled = CanBeLocationAdded();
        }

        private bool CanBeLocationAdded()
        {
            if (errorProvider.GetError(txtLatitude) != string.Empty || string.IsNullOrEmpty(txtLatitude.Text))
                return false;
            if (errorProvider.GetError(txtLongitude) != string.Empty || string.IsNullOrEmpty(txtLongitude.Text))
                return false;
            return true;
        }

        private void checkIsTimeOffset_CheckedChanged(object sender, System.EventArgs e)
        {
            numTimeOffset.Enabled = checkIsTimeOffset.Checked;
        }
    }
}
