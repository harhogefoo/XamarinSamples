using System;
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

            // var dateStr = DateTime.Now.ToString("u");
            // MainPage = new NavigationPage(new Page1Xaml(dateStr));
            // MainPage = new TabbedPageSample();
            // MainPage = new SettingPage();
            // MainPage = new FooterButtonPage();
            // MainPage = new TabbedLikePageTop();
            // MainPage = new NavigationPage(new TabbedLikePageTop()) { BarBackgroundColor = Color.Aqua };
            // MainPage = new CarouselPageSample();
            // MainPage = new CaroucelViewSample();
            // MainPage = new CaroucelViewPluginSample();
            // MainPage = new CaroucelViewPluginWithListViewSample();
            // MainPage = new HttpClientSample();
            // MainPage = new CheckNetworkConnectionPage();
            // MainPage = new LoginPage();
            // MainPage = new ScrollViewSamplePage();
            // MainPage = new InfiniteListViewPage();

            var csTab = new TabbedPage();

            csTab.Children.Add(new DevicePage { Title = "C#", Icon = "icon_clip.png" });
            csTab.Children.Add(new DevicePageXaml { Title = "Xaml", Icon = "icon_clip.png" });

            //MainPage = csTab;
            // MainPage = new HorizontalListView();
            MainPage = new TryDevicePage();
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
