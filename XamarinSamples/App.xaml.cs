﻿using System;
using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			// MainPage = new HelloXamlPage();
			// MainPage = new XamlPlusCodePage();
			// MainPage = new SharedResourceSample();
			// MainPage = new StaticConstantsPage();
			// MainPage = new SliderBindingPage();
			// MainPage = new OneShotDateTimePage();
			// MainPage = new ClockPage();
			// MainPage = new HslColorScrollPage();
			// MainPage = new KeypadPage();
			// MainPage = new UseResourceDictionaryPage();
			var dateStr = DateTime.Now.ToString("u");
			MainPage = new NavigationPage(new Page1Xaml(dateStr));
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}