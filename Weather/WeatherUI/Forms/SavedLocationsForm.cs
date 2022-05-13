using System;
using System.Collections.Generic;
using WeatherLibrary.Helpers;
using WeatherLibrary.Objects;

namespace WeatherUI.Forms
{
    public partial class SavedLocationsForm : FormBase
    {
        private List<Location> Locations { get; set; }
        public SavedLocationsForm()
        {
            InitializeComponent();
            Locations = ConfigHelper.Instance.GetLocations();
            fillListBox();
            if (Locations.Count > 0)
                listBoxLocations.SelectedIndex = 0;
            else
                btnRemove.Enabled = false;
        }

        private void fillListBox()
        {
            foreach (Location location in Locations)
            {
                listBoxLocations.Items.Add(location.Name);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            ConfigHelper.Instance.RemoveLocation(listBoxLocations.SelectedIndex);
            listBoxLocations.Items.RemoveAt(listBoxLocations.SelectedIndex);
            if (listBoxLocations.Items.Count == 0)
                btnRemove.Enabled = false;
        }
    }
}
