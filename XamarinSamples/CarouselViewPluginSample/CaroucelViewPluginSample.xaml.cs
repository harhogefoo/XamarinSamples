using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using CarouselView.FormsPlugin.Abstractions;

namespace XamarinSamples
{
    public partial class CaroucelViewPluginSample : ContentPage
    {
        ObservableCollection<Zoo> Zoos { get; set; }

        public CaroucelViewPluginSample()
        {
            InitializeComponent();

            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += (sender, e) =>
            {
                Utility.Log(sender.ToString() + ": pan");
            };
            Utility.Log("CaroucelViewPluginSample");

            MonkeysViewModel mvm = new MonkeysViewModel();

            var cv = new CarouselViewControl
            {
                Orientation = Orientation.Horizontal,
            };

            DataTemplate dataTemplate = new DataTemplate(() =>
            {
                Grid grid = new Grid();
                RowDefinitionCollection rd = new RowDefinitionCollection();
                rd.Add(new RowDefinition { Height = GridLength.Star });
                rd.Add(new RowDefinition { Height = GridLength.Auto });

                grid.RowDefinitions = rd;
                grid.SetBinding(Grid.BindingContextProperty, "Zoo");

                Image image = new Image();
                image.SetBinding(Image.SourceProperty, "Image");
                image.Aspect = Aspect.AspectFill;
                grid.Children.Add(image, 0, 0);
                Grid.SetRowSpan(image, 2);
                // image.GestureRecognizers.Add(panGesture);

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

                return grid;
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


            var gesture = new TapGestureRecognizer();
            gesture.Tapped += (sender, e) =>
            {
                Utility.Log("tapped");
            };
            cv.GestureRecognizers.Add(gesture);

            cv.GestureRecognizers.Add(panGesture);
            var pinchGesture = new PinchGestureRecognizer();
            pinchGesture.PinchUpdated += (sender, e) =>
            {
                Utility.Log("pinch");
            };



            layout.GestureRecognizers.Add(panGesture);
        }

    }
}
