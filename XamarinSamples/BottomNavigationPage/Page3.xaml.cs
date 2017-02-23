using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Bottombar.XamarinForms
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            Content = new Label
            {
                Text = "Hello Tabbed With Navigation Page 3!",
                TextColor = Color.FromHex("#666666"),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
            };
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
