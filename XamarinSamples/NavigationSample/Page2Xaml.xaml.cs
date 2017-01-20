using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class Page2Xaml : ContentPage
	{
		public Page2Xaml()
		{
			InitializeComponent();
		}

		override protected void OnAppearing()
		{
			System.Diagnostics.Debug.WriteLine("Page 2 Appear");
		}

		override protected void OnDisappearing()
		{
			System.Diagnostics.Debug.WriteLine("Page 2 Disappear");
		}

		async void OnPreviousPageButtonClicked(object sender, EventArgs e)
		{
			// await Navigation.PopAsync();
			// Page appearance note animated
			await Navigation.PopAsync(false);
		}
	}
}
