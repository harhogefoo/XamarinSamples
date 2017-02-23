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

			System.Diagnostics.Debug.WriteLine("Constractor");

			var headerView = new PACDHeaderBox
			{
				BackgroundColor = Color.FromHex("#3BB0C9"),
			};

			var layout = new AbsoluteLayout();
			layout.Children.Add(headerView, new Point(0, 0));

			Content = layout;

        }
    }
}
