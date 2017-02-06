using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
    public partial class TryDevicePage : ContentPage
    {
        public TryDevicePage()
        {
            InitializeComponent();
        }

        void CallButtonPushed(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:09015316991"));
        }

        void DialButtonPushed(object sender, EventArgs e)
        {

        }

        void SkypeButtonPushed(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("skype:09015316991"));
        }
    }
}
