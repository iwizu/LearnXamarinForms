using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static UniBooks.GoogleBooksService;

namespace UniBooks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionPage : ContentPage, INotifyPropertyChanged
    {
        private ObservableCollection<ABook> bookList;
        public ObservableCollection<ABook> BookList
        {
            get { return bookList; }
            set
            {
                bookList = value;
                OnPropertyChanged("Books");
            }
        }

        public CollectionPage()
        {
            InitializeComponent();
            Title = "Your book collection";
            BookList = new ObservableCollection<ABook>();
            BindingContext = this;
            test.ItemsSource = BookList;
        }

        public async void SearchForBooks()
        {
            //BookList = new ObservableCollection<ABook>();
            var res =await App.Database.GetAllBooks();
            BookList.Clear();
            foreach (var item in res)
            {
                BookList.Add(item);
            }
            Device.BeginInvokeOnMainThread(() =>
            {
                //test.ItemsSource = BookList;
            });
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            SearchForBooks();

        }

        private async void ReadBtn_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string id = btn.CommandParameter.ToString();
            ABook a=await App.Database.GetBook(id);
            
            if (a != null)
             await   Navigation.PushModalAsync(new NavigationPage(new ReadPage(a))
                {
                    BarBackgroundColor = Color.FromHex("7BABED"),
                     BarTextColor= Color.FromHex("FCFCFE"),
                 Title = "Book Reader"
             });
        }
    }
}