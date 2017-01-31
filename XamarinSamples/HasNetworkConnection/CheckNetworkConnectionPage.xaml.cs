using System;
using System.Collections.Generic;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace XamarinSamples
{
    public partial class CheckNetworkConnectionPage : ContentPage
    {
        public CheckNetworkConnectionPage()
        {
            InitializeComponent();
            // CrossConnectivity.Current.ConnectivityTypeChanged += Current_ConnectivityTypeChanged;
        }

        private async void Current_ConnectivityTypeChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityTypeChangedEventArgs e)
        {
            if (!e.IsConnected)
            {
                await DisplayAlert("Error", "Check for your connection.", "OK");
            }
            else {
                await DisplayAlert("Success", "Network is Available.", "OK");
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (!CrossConnectivity.Current.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("connected");
                await DisplayAlert("Error", "Check for your connection", "OK");
            }
            else {
                await DisplayAlert("Success", "Network is Available.", "OK");
            }
        }
    }
}
