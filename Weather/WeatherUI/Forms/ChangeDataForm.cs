using System.Windows.Forms;
using WeatherLibrary.Enums;

namespace WeatherUI.Forms
{
    public partial class ChangeDataForm : FormBase
    {
        public Data DataEnum { get; set; }
        public ChangeDataForm(Data actualData)
        {
            InitializeComponent();
            cmbData.SelectedIndex = (int)actualData;
        }

        private void cmbData_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataEnum = (Data)cmbData.SelectedIndex;
        }

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ChangeDataForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
