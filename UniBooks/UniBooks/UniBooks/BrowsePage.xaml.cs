using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static UniBooks.GoogleBooksService;

namespace UniBooks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowsePage : ContentPage, INotifyPropertyChanged
    {       
        private ObservableCollection<BookModel> bookList;
        public ObservableCollection<BookModel> BookList
        {
            get { return bookList; }
            set
            {
                if (bookList != value)
                {
                    bookList = value;

                    OnPropertyChanged("Books");

                    PropertyChanged?.Invoke(this,
    new PropertyChangedEventArgs("Books"));
                }
            }
        }
        private string title;
        public string ATitle
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;

                    OnPropertyChanged("Title");                                      
                }
            }
        }

        public BrowsePage()
        {
            InitializeComponent();
            Title = "Search for a book";
            ATitle = "Search for a book";
            BookList = new ObservableCollection<BookModel>();
            BindingContext = this;            
            test.ItemsSource = BookList;
            //SearchForBooks("Self");

        }

        public async void SearchForBooks(string q)
        {
            var res = await App.BooksServiceManager.GetBooksAsync(q);
            var d=JsonConvert.DeserializeObject<Books>(res.Content);
            var books = d.items;
            BookList.Clear();
            foreach (var item in d.items)
            {
                BookList.Add(item);
            }
            //BookList = temp;
            Device.BeginInvokeOnMainThread(() =>
            {
                //test.ItemsSource = BookList;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void SearchBtn_Clicked(object sender, EventArgs e)
        {
            SearchForBooks(SearchTxt.Text);
        }

        private void BuyBtn_Clicked(object sender, EventArgs e)
        {
            //this.Navigation.PushModalAsync(new BuyPage());
            //App.NavigationService.NavigateTo("BuyPage");
            Button btn = sender as Button;
            string id= btn.CommandParameter.ToString();
            var book = BookList.FirstOrDefault(i => i.id == id);
            if (book != null)
                Navigation.PushModalAsync(new NavigationPage(new BuyPage(book)) {
                    BarBackgroundColor = Color.FromHex("7BABED"),
                    BarTextColor= Color.FromHex("FCFCFE")
                });
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("UniBooks", "Search and Buy your favorite books!", "OK");
        }
    }
}