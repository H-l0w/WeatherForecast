using System;
using System.Collections.Generic;
using System.Data;
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
                dataGridLocations.Rows[0].Selected = true;
            else
                btnRemove.Enabled = false;
        }

        private void fillListBox()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Region");
            table.Columns.Add("Country");
            table.Columns.Add("Continent");
            foreach (Location location in Locations){
                table.Rows.Add(location.Name, location.Region, location.Country, location.Continent);
            }
            dataGridLocations.DataSource = table;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridLocations.SelectedRows.Count == 0 && dataGridLocations.SelectedCells.Count == 0)
                return;
            int index;
            if (dataGridLocations.SelectedRows.Count == 0)
                index = dataGridLocations.SelectedCells[0].RowIndex;
            else
                index = dataGridLocations.SelectedRows[0].Index;

            ConfigHelper.Instance.RemoveLocation(index);
            dataGridLocations.Rows.RemoveAt(index);
            SessionHelper.Instance.Locations.RemoveAt(index);
            if (dataGridLocations.Rows.Count == 0)
                btnRemove.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
