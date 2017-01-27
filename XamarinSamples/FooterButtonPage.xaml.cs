using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class FooterButtonPage : ContentPage
	{
		public FooterButtonPage()
		{
			InitializeComponent();

			for (var i = 0; i < 3; i++)
			{
				var button = new Button { Text = "button" + i, BackgroundColor = Color.Blue, HorizontalOptions = LayoutOptions.FillAndExpand };
				footer.Children.Add(button);
			}
		}
	}
}
