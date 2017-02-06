using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace XamarinSamples
{
    public partial class HorizontalListView : ContentPage
    {
        public HorizontalListView()
        {
            InitializeComponent();
            HorizontalList.HorizontalListView hlv = new HorizontalList.HorizontalListView()
            {
                ListOrientation = StackOrientation.Horizontal
            };

            ObservableCollection<Button> oc = new ObservableCollection<Button>();
            for (var i = 0; i < 10; i++)
            {
                Button button = new Button
                {
                    Text = i.ToString()
                };
                oc.Add(button);
            }

            hlv.ItemsSource = oc;

            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(hlv);

            Content = stackLayout;
        }
    }
}
