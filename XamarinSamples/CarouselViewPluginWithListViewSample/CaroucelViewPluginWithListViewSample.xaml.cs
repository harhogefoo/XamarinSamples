using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using CarouselView.FormsPlugin.Abstractions;

namespace XamarinSamples
{
    public partial class CaroucelViewPluginWithListViewSample : ContentPage
    {
        ObservableCollection<Zoo> Zoos { get; set; }

        public CaroucelViewPluginWithListViewSample()
        {
            InitializeComponent();

			var pacdContentView = new PACDCarouselPageView();

			var headerView = new PACDHeaderBox
			{
				BackgroundColor = Color.FromHex("#3BB0C9"),
				PDContentView = pacdContentView,
			};
			headerView.SetPDContentView(pacdContentView);

			//イベントマネージャーに登録する
			PACDEventManager.Instance().SetFixedItems(pacdContentView, headerView);

			var layout = new AbsoluteLayout();
			layout.Children.Add(headerView, new Point(0, 0));
			layout.Children.Add(pacdContentView, new Point(0, 120));

			Content = layout;

            //ParentGrid.Children.Add(cv);

            //var zoo = new Zoo
            //{
            //    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/e8179889-8189-4acb-bac5-812611199a03/2016-06-02_1053.png",
            //    Name = "Phoenix Zoo"
            //};
            //mvm.Unshift(zoo);
			//cv.Position = 0;
        }

    }
}
