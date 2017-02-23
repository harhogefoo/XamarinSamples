using System;

using Xamarin.Forms;

namespace Bottombar.XamarinForms
{
    public class Page1 : ContentPage
    {
        public Page1()
        {

            Content = new Label
            {
                Text = "Hello Tabbed Page 2!",
                TextColor = Color.FromHex("#666666"),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.Center
            };

        }
    }
}

