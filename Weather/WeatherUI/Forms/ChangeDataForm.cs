using System;
using System.Windows.Forms;
using WeatherLibrary.Enums;
using WeatherLibrary.Factories;

namespace WeatherUI.Forms
{
    public partial class ChangeDataForm : FormBase
    {
        public Data DataEnum { get; set; }
        public ChangeDataForm(Data actualData)
        {
            InitializeComponent();
            FillListBox();
            listBoxData.SelectedIndex = (int)actualData;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FillListBox()
        {
            foreach (Data data in (Data[]) Enum.GetValues(typeof(Data))) {
                listBoxData.Items.Add(EnumHelper.GetDescription(data));
            }
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataEnum = (Data)listBoxData.SelectedIndex;
        }
    }
}
