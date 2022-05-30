using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherLibrary.Factories;
using WeatherLibrary.Objects;
using WeatherLibrary.Helpers;
using Newtonsoft.Json.Linq;

namespace WeatherUI.Forms
{
    public partial class LocationForm : FormBase
    {

        private readonly LocationRepo locationFactory;
        public Location SelectedLocation { get; set; }
        private bool StartNewWindow { get; set; }
        private bool isApiKeyValid;
        private bool ignoreMessageBox;
        public bool IsLocationAdded = false;

        List<Location> Locations { get; set; }
        public LocationForm(bool startNewWindow, bool isApiKeyValid = true)
        {
            StartNewWindow = startNewWindow;
            this.isApiKeyValid = isApiKeyValid;
            locationFactory = new LocationRepo();
            InitializeComponent();
            addColumns();
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            if (!isApiKeyValid)
                MessageBox.Show(this, "Api key is not valid, please edit it in settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addColumns()
        {
            dataGridLocations.ColumnCount = 4;

            dataGridLocations.Columns[0].Name = "Name";
            dataGridLocations.Columns[1].Name = "Continent";
            dataGridLocations.Columns[2].Name = "State";
            dataGridLocations.Columns[3].Name = "Region";
        }

        private async Task fillDataGrid()
        {
            if (dataGridLocations.RowCount > 0)
                deleteRows();

            List<Location> locations = await GetLocaions();

            if ((locations == null && !ignoreMessageBox))
            {
                MessageBox.Show("Unable to find location");
                return;
            }

            if (locations == null || locations.Count == 0) {
                MessageBox.Show("Unable to find location");
                return;
            }
            
            if (locations == null) {
                ignoreMessageBox = false;
                return;
            }

            foreach (Location location in locations)
            {
                dataGridLocations.Rows.Add(location.Name, location.Continent, location.Country, location.Region);
            }
        }

        private void deleteRows()
        {
            int rows = dataGridLocations.RowCount;
            for (int i = rows -1; i >= 0; i--)
            {
                dataGridLocations.Rows.RemoveAt(i);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtLocation.Text;

            if (searchText.Length < 3)
            {
                MessageBox.Show("Location name must be atleast 3 charactes long");
                return;
            }

            await fillDataGrid();
        }

        private async Task<List<Location>> GetLocaions()
        {
            try
            {
                Locations = await locationFactory.GetLocations(txtLocation.Text, 10);
                return Locations;
            }
            catch (Exception e)
            {
                if (e.Message == "Response status code does not indicate success: 401 (Unauthorized).") {
                    MessageBox.Show(this, "Api key is not valid, please edit it in settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ignoreMessageBox = true;
                }
                else 
                    MessageBox.Show(this, "Error while searching locations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void txtLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                await fillDataGrid();
            }
        }

        private async void dataGridLocations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridLocations.Rows[e.RowIndex].Selected = true;
                Location location = GetLocationFromGrid(e.RowIndex);
                var res = await HttpHelper.Instance.SendRequest(UrlHelper.Instance.BuildUrlTimeZone(location.Latitude, 
                    location.Longitude, SessionHelper.Instance.ApiKeyTimeZone));

                try {
                    dynamic json = JObject.Parse(res);
                    if (json.status == "OK") {
                        int offset = json.gmtOffset;
                        location.IsTimeZoneSet = true;
                        location.TimeOffset = offset;
                    }
                }
                catch (Exception ex) {
                    location.TimeOffset = 0;
                    location.IsTimeZoneSet= false;
                }
                finally {
                    if (checkSaveSelectedLocation.CheckState == CheckState.Checked) {
                        ConfigHelper.Instance.SaveLocation(location, true);
                    }
                    SessionHelper.Instance.Locations.Add(location);
                    SelectedLocation = location;
                    if (StartNewWindow)
                        ShowWeatherForm(SelectedLocation);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void ShowWeatherForm(Location location)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.Hide();
                WeatherForm form = new WeatherForm();
                form.Closed += (s, args) => this.Close();
                form.Show();
            });
        }

        private Location GetLocationFromGrid(int rowIndex)
        {
            DataGridViewRow row = dataGridLocations.Rows[rowIndex];

            Location location = Locations.FirstOrDefault(l =>
            l.Name == (string)row.Cells[0]?.Value
            && l.Continent == (string)row.Cells[1]?.Value
            && l.Country == (string)row.Cells[2]?.Value
            && l.Region == (string)row.Cells[3]?.Value);
            return location;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApplicationSettings_Click(object sender, EventArgs e)
        {
            ApplicationSettingsForm form = new ApplicationSettingsForm();
            form.Show();
        }

        private void btnAddLocationManually_Click(object sender, EventArgs e)
        {
            ManualLocationAddForm form = new ManualLocationAddForm();
            var res = form.ShowDialog();

            if (res == DialogResult.OK) {
                if (checkSaveSelectedLocation.CheckState == CheckState.Checked) {
                    ConfigHelper.Instance.SaveLocation(form.NewLocation, true);
                }
                SessionHelper.Instance.Locations.Add(form.NewLocation);
                SelectedLocation = form.NewLocation;
                IsLocationAdded = true;

                if (SessionHelper.Instance.Locations.Count == 1)
                    ShowWeatherForm(form.NewLocation);
            }
        }
    }
}
