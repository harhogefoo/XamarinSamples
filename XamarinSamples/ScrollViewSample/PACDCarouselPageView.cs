using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using CarouselView.FormsPlugin.Abstractions;

namespace XamarinSamples
{
	public class PACDCarouselPageView : CarouselViewControl
	{
		public PACDCarouselPageView()
		{
			Orientation = Orientation.Horizontal;

			Focused += (sender, e) =>
			{
				Utility.Log("focus!");
			};

			MeasureInvalidated += (sender, e) =>
			{
				Utility.Log("measure");
			};

			PropertyChanged += (sender, e) =>
			{
				Utility.Log("pro");
			};

			PropertyChanging += (sender, e) =>
			{
				Utility.Log("proing");
			};

			PositionSelected += (sender, e) =>
			{
				Utility.Log("pos");
				Utility.Log(this.X);
				Utility.Log(this.AnchorX);
				Utility.Log(this.TranslationX);
				Utility.Log("Position:" + this.Position);
				PACDEventManager.Instance().SetPagePosition(this.Position);
			};

			MonkeysViewModel mvm = new MonkeysViewModel();
			ItemsSource = mvm.Zoos;
			ItemTemplate = CreatePhoneDirectoryDataTemplate();
		}

		private DataTemplate CreatePhoneDirectoryDataTemplate() { 
			
			DataTemplate dataTemplate = new DataTemplate(() =>
			{
				Grid grid = new Grid();
				RowDefinitionCollection rd = new RowDefinitionCollection();
				rd.Add(new RowDefinition { Height = GridLength.Star });
				rd.Add(new RowDefinition { Height = GridLength.Auto });

				ListView listView = new ListView();
				// listView.SetBinding(ListView.BindingContextProperty, "Zoo");
				listView.ItemsSource = new ObservableCollection<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, };

				grid.RowDefinitions = rd;
				grid.SetBinding(Grid.BindingContextProperty, "Zoo");

				Image image = new Image();
				image.SetBinding(Image.SourceProperty, "Image");
				image.Aspect = Aspect.AspectFill;
				grid.Children.Add(image, 0, 0);
				Grid.SetRowSpan(image, 2);

				StackLayout stackLayout = new StackLayout
				{
					BackgroundColor = Color.FromHex("#80000000"),
					Padding = 12,
				};
				grid.Children.Add(stackLayout, 0, 1);

				Label label = new Label();
				label.SetBinding(Label.TextProperty, "Name");
				label.TextColor = Color.White;
				label.FontSize = 16;
				label.HorizontalOptions = LayoutOptions.Center;
				label.VerticalOptions = LayoutOptions.CenterAndExpand;
				stackLayout.Children.Add(label);

				return listView;
			});

			return dataTemplate;
		}


	}
}
