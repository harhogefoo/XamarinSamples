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

            MonkeysViewModel mvm = new MonkeysViewModel();

            var cv = new CarouselViewControl
            {
                Orientation = Orientation.Horizontal,
            };
            cv.Focused += (sender, e) =>
            {
                Utility.Log("focus!");
            };
            cv.MeasureInvalidated += (sender, e) =>
            {
                Utility.Log("measure");
            };
            cv.PropertyChanged += (sender, e) =>
            {
                Utility.Log("pro");
            };
            cv.PropertyChanging += (sender, e) =>
            {
                Utility.Log("proing");
            };
            cv.PositionSelected += (sender, e) =>
            {
                Utility.Log("pos");
                Utility.Log(cv.X);
                Utility.Log(cv.AnchorX);
                Utility.Log(cv.TranslationX);
            };

            DataTemplate dataTemplate = new DataTemplate(() =>
            {
                Grid grid = new Grid();
                RowDefinitionCollection rd = new RowDefinitionCollection();
                rd.Add(new RowDefinition { Height = GridLength.Star });
                rd.Add(new RowDefinition { Height = GridLength.Auto });

                ListView listView = new ListView();
                // listView.SetBinding(ListView.BindingContextProperty, "Zoo");
                listView.ItemsSource = new ObservableCollection<int> { 1, 2, 3, 4, 5 };

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

            cv.ItemsSource = mvm.Zoos;
            cv.ItemTemplate = dataTemplate;
            ParentGrid.Children.Add(cv);

            var zoo = new Zoo
            {
                ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/e8179889-8189-4acb-bac5-812611199a03/2016-06-02_1053.png",
                Name = "Phoenix Zoo"
            };
            mvm.Unshift(zoo);
            cv.Position = 1;
        }

    }
}
