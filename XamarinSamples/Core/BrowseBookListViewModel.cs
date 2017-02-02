using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace XamarinSamples
{
    public class BrowseBookListViewModel
    {
        public ObservableCollection<Book> BookList { get; set; }
        public int pageNumber;

        ObservableCollection<Book> BrowseBookListModelEntity;
        public BrowseBookListViewModel()
        {
            BrowseBookListModelEntity = new ObservableCollection<Book>();
            for (var i = 0; i < 5; i++)
            {
                var book = new Book
                {
                    ViewCellBackgroundColor = Color.Aqua,
                    BookSerialNO = i,
                    BookTitle = i.ToString(),
                    BookAuthorPublishing = i.ToString()
                };
                BrowseBookListModelEntity.Add(book);
            }
        }

        public ObservableCollection<Book> getBrowseBookListModelEntity()
        {
            return BrowseBookListModelEntity;
        }

        public async Task AddNextPageData()
        {
            try
            {
                //Increase page counter to retrieve next page from Database
                pageNumber++;

                //Retrieve list of Books then assign it to List <BrowseBookListModel>
                List<Book> nextPage = await getBrowseBookList(pageNumber, 5);

                //Store List <BrowseBookListModel> in BrowseBookListModelEntity to show it in Views
                foreach (var item in nextPage)
                    getBrowseBookListModelEntity().Add(item);
            }
            finally
            {

            }
        }

        async Task<List<Book>> getBrowseBookList(int pageNumber, int itemsPerPage)
        {
            var bookList = await Task.Run(() =>
            {
                var list = new List<Book>();
                for (var i = 0; i < 5; i++)
                {
                    var book = new Book
                    {
                        ViewCellBackgroundColor = Color.Aqua,
                        BookSerialNO = i,
                        BookTitle = i.ToString(),
                        BookAuthorPublishing = i.ToString()
                    };
                    list.Add(book);
                }
                return list;
            });

            return bookList;

        }

    }
}
