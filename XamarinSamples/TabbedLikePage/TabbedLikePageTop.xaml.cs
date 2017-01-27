using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace XamarinSamples
{
	public partial class TabbedLikePageTop : ContentPage
	{
		public TabbedLikePageTop()
		{
			InitializeComponent();

			for (var i = 0; i < 5; i++)
			{
				var button = new ImageButton()
				{
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					ImageHeightRequest = 25,
					ImageWidthRequest = 25,
					Orientation = XLabs.Enums.ImageOrientation.ImageOnTop,
					Source = "icon_clip",
					Text = "電話帳",
					FontSize = 12,
				};
				
				//var button = new Button
				//{
				//	Text = i.ToString(),
				//	HorizontalOptions = LayoutOptions.FillAndExpand,
				//	BackgroundColor = Color.Blue,
				//	BorderRadius = 0,

				//};
				//button.Clicked += OnButtonClicked;

				footer.Children.Add(button);
			}
		}

		void OnButtonClicked(object sender, EventArgs e)
		{

		}
	}
}
