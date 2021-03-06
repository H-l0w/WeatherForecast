using System;
using System.Drawing;
using System.Windows.Forms;
using WeatherLibrary.Enums;
using WeatherLibrary.Factories;
using WeatherLibrary.Objects;
using WeatherUI.Forms;

namespace WeatherUI.Controls
{
    public partial class HourInfo : UserControl
    {
        public WeatherCodes? Code { get; set; }
        public string Time { get; set; }
        public int Day { get; set; }
        public string Value { get; set; }
        private string toolTipText;
        private ToolTip toolTip;
        public Location Location_ { get; set; }
        public Detail Detail { get; set; }

        public HourInfo()
        {
            toolTip = new ToolTip();
            InitializeComponent();
            SubscribeEvents();
            pctIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        public void SetControls()
        {
            pctIcon.Width = (int)(Width * 0.5);
            pctIcon.Height = (int)(Height * 0.5);
            int sideDistance = (Width - pctIcon.Width) / 2;
            int topBottomDistance = (Height - pctIcon.Height) / 8;
            pctIcon.Location = new Point(sideDistance, topBottomDistance);

            sideDistance = (Width - lblTime.Width) / 2;
            topBottomDistance = (Height - lblTime.Height) / 8;
            lblTime.Location = new Point(sideDistance, (int)(topBottomDistance + pctIcon.Height * 0.9));

            sideDistance = (Width - lblValue.Width) / 2;
            topBottomDistance = (Height - lblValue.Height) / 8;
            lblValue.Location = new Point(sideDistance, (int)(topBottomDistance + pctIcon.Height  * 0.85 + lblTime.Height) );
        }

        public void HourInfo_Load(object sender, EventArgs e)
        {
            Reload();
            SetControls();
            SetToolTips();
            SetRightMenuClick();
        }

        private void SetColor()
        {   
            string hour = DateTime.UtcNow.AddSeconds(Location_.TimeOffset).ToString("HH");
            if (Time.Contains(hour) && Location_.IsTimeZoneSet && Day == DateTime.UtcNow.Day)
                this.BackColor = Color.Cyan;
            else
                this.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void SetToolTips()
        {
            string weather = EnumHelper.GetDescription(Code);

            toolTipText = $"Time: {Time} Value: { Value} Weather: {weather}";

            toolTip.SetToolTip(this, toolTipText);
            toolTip.SetToolTip(pctIcon, toolTipText);
            toolTip.SetToolTip(lblTime, toolTipText);
            toolTip.SetToolTip(lblValue, toolTipText);
        }

        private void SetRightMenuClick()
        {
            menuRightClick.Items.Add("Show detail");
        }

        public void Reload()
        {
            if (Code == null)
                pctIcon.Image = Image.FromStream(IconRepo.GetIcon("Error"));
            else
                pctIcon.Image = Image.FromStream(IconRepo.GetIcon(EnumHelper.GetDescription(Code)));
            lblTime.Text = Time;
            lblValue.Text = Value;
            SetToolTips();
            SetColor();
        }


        private void MouseHoverOverControl(object sender, EventArgs e) =>this.BackColor = Color.Coral;

        private void MouseLeaveOverControl(object sender, EventArgs e) => SetColor();

        private void SubscribeEvents()
        {
            this.MouseEnter += MouseHoverOverControl;
            pctIcon.MouseEnter += MouseHoverOverControl;
            lblTime.MouseEnter += MouseHoverOverControl;
            lblValue.MouseEnter += MouseHoverOverControl;

            this.MouseLeave += MouseLeaveOverControl;
            pctIcon.MouseLeave += MouseLeaveOverControl;
            lblTime.MouseLeave += MouseLeaveOverControl;
            lblValue.MouseLeave += MouseLeaveOverControl;

            this.DoubleClick += InfoDoubleClick;
            pctIcon.DoubleClick += InfoDoubleClick;
            lblTime.DoubleClick += InfoDoubleClick;
            lblValue.DoubleClick += InfoDoubleClick;

            this.MouseClick += InfoMouseClick;
            pctIcon.MouseClick += InfoMouseClick;
            lblTime.MouseClick += InfoMouseClick;
            lblValue.MouseClick += InfoMouseClick;
        }

        private void InfoDoubleClick(object sender, EventArgs e)
        {
            WeatherDetailForm detailForm = new WeatherDetailForm(Detail);
            detailForm.Show();
        }

        private void InfoMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                menuRightClick.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void menuRightClick_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Show detail") {
                WeatherDetailForm form = new WeatherDetailForm(Detail);
                form.Show();
            }
        }
    }
}
