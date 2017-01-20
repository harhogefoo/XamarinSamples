using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	class Contact
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Occupation { get; set; }
		public string Country { get; set; }
	}

	public partial class Page1Xaml : ContentPage
	{
		public Page1Xaml()
		{
			InitializeComponent();
		}

		// データの受け渡し
		public Page1Xaml(string date)
		{
			InitializeComponent();
			dateLabel.Text = date;
		}

		async void OnNextPageButtonClicked(object sender, EventArgs e)
		{

			Contact contact = new Contact
			{
				Name = "harhogefoo",
				Age = 24,
				Occupation = "Developer",
				Country = "Japan"
			};

			var secondPage = new Page2Xaml();
			secondPage.BindingContext = contact;
			await Navigation.PushAsync(secondPage);
		}
	}
}
