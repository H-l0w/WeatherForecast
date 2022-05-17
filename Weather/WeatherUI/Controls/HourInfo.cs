﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeatherLibrary.Enums;
using WeatherLibrary.Factories;

namespace WeatherUI.Controls
{
    public partial class HourInfo : UserControl
    {
        public WeatherCodes? Code { get; set; }
        public string Time { get; set; }
        public string Value { get; set; }
        private string toolTip;

        public HourInfo()
        {
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
            string weather = EnumFactory.GetDescription(Code);

            toolTip = $"Time: {Time} Value: { Value} Weather: {weather.Remove(weather.Length - 4)}";
            
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this, toolTip);
            tip.SetToolTip(pctIcon, toolTip);
            tip.SetToolTip(lblTime, toolTip);
            tip.SetToolTip(lblValue, toolTip);
        }

        public void Reload()
        {
            if (Code == null)
                pctIcon.Image = Image.FromStream(IconFactory.GetIcon("Error.png"));
            else
                pctIcon.Image = Image.FromStream(IconFactory.GetIcon(EnumFactory.GetDescription(Code)));
            lblTime.Text = Time;
            lblValue.Text = Value;
        }


        private void MouseHoverOverControl(object sender, EventArgs e) =>this.BackColor = Color.Coral;

        private void MouseLeaveOverControl(object sender, EventArgs e) => this.BackColor = Color.FromKnownColor(KnownColor.Control);

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
        }

    }
}
