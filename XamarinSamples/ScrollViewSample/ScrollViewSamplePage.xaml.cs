using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
    public partial class ScrollViewSamplePage : ContentPage
    {
        public ScrollViewSamplePage()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 200,
            };

            for (var i = 0; i < 100; i++)
            {
                Button button = new Button
                {
                    Text = "Button-" + i.ToString()
                };

                stack.Children.Add(button);
            };
            scrollView.Content = stack;

            scrollView.Scrolled += (sender, e) =>
            {
                Utility.Log("ed");

            };
        }
    }
}
