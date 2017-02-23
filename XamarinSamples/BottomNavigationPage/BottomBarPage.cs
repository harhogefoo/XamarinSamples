using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Bottombar.XamarinForms
{
    public class BottomBarPage : TabbedPage
    {
        public BottomBarPage()
        {
            this.Title = "C# TabbedPage";
            this.Padding = new Thickness(0, Device.OnPlatform(0, 20, 0), 0, 0);
            // ChildrenにPageを列挙していきます。Pageを参照しても直接書いてもOK。
            // iOSにだけIconが必要で、白のアイコンでFILENAME@2xを48px、FILENAME@3xを72pxで用意します。

            this.Children.Add(new Page1()
            {
                Title = "TabPage 1",
                Icon = "icon_clip.png"
            });
            this.Children.Add(new ContentPage
            {
                Title = "TabPage 2",
                Icon = "icon_clip.png",
                BackgroundColor = Color.FromHex("#eeffee"),
                Content = new Label
                {
                    Text = "Hello Tabbed Page 2!",
                    TextColor = Color.FromHex("#666666"),
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalTextAlignment = TextAlignment.Center
                }
            });
            var navPage = new NavigationPage(new Page3())
            {
                Title = "TabPage 3",
                Icon = "icon_clip.png",
            };
            NavigationPage.SetHasNavigationBar(navPage, false);
            this.Children.Add(navPage);
        }
        public enum BarThemeTypes { Light, DarkWihAlpha, DarkWithoutAlpha }

        public bool FixedMode { get; set; }
        public BarThemeTypes BarTheme { get; set; }

        public void RaiseCurrentPageChanged()
        {
            OnCurrentPageChanged();
        }
    }
}
