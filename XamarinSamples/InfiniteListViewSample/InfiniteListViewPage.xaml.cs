using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace XamarinSamples
{
    public partial class InfiniteListViewPage : ContentPage
    {
        BrowseBookListViewModel browseBookListViewModel = new BrowseBookListViewModel();
        public InfiniteListViewPage()
        {
            InitializeComponent();
            BrowseBookList.ItemsSource = browseBookListViewModel.getBrowseBookListModelEntity();
        }

        private async void BrowseBookList_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var viewCellDetails = e.Item as Book;
            int viewCellIndex = browseBookListViewModel.getBrowseBookListModelEntity().IndexOf(viewCellDetails);
            if (viewCellIndex >= 0)
            {
                if (IsOdd(viewCellIndex))
                {
                    viewCellDetails.ViewCellBackgroundColor = Color.FromHex("#f9f9f9");
                }
                else
                {
                    viewCellDetails.ViewCellBackgroundColor = Color.FromHex("#f1eeee");
                }
            }
            if (browseBookListViewModel.getBrowseBookListModelEntity().Count - 2 <= viewCellIndex)
            {
                await browseBookListViewModel.AddNextPageData();
            }

        }

        private void BrowseBookList_ItemSelected(object sender, EventArgs e)
        {

        }

        private bool IsOdd(int index)
        {
            return (index % 2) != 0;

        }
    }

}
