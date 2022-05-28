using System.Drawing;
using System.Windows.Forms;
using WeatherLibrary.Helpers;

namespace WeatherUI.Forms
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            this.BackColor = SessionHelper.Instance.Background;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.KeyPreview = true;
        }
    }
}
