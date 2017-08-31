using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static UniBooks.GoogleBooksService;

namespace UniBooks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuyPage : ContentPage
    {
        private BookModel book;
        public BookModel Book
        {
            get { return book; }
            set
            {
                book = value;
            }
        }
        public BuyPage(BookModel book)
        {
            InitializeComponent();
            Title = "Book payment";
            Book = book;
            
            this.BindingContext = this;
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            //App.NavigationService.NavigateTo("MainPage");
            Navigation.PopModalAsync();
            var bks = App.Database.GetAllBooks();

        }

        private void BuyBtn_Clicked(object sender, EventArgs e)
        {
            ABook a = new ABook();
            foreach (var i in Book.volumeInfo.authors)
                a.authors += i + " - ";
            a.averageRating = Book.volumeInfo.averageRating;
            a.description = Book.volumeInfo.description;
            a.Id = Book.id;
            a.listPrice = Book.saleInfo.listPrice!=null?Book.saleInfo.listPrice.amount:0;
            a.pageCount = Book.volumeInfo.pageCount;
            a.publishedDate = Book.volumeInfo.publishedDate;
            a.publisher = Book.volumeInfo.publisher;
            a.ratingsCount = Book.volumeInfo.ratingsCount;
            a.saleability = Book.saleInfo.saleability;
            a.smallThumbnail = Book.volumeInfo.imageLinks.smallThumbnail;
            a.thumbnail = Book.volumeInfo.imageLinks.thumbnail;
            a.subtitle = Book.volumeInfo.subtitle;
            a.title = Book.volumeInfo.title;
            
           App.Database.SaveBook(a);
           DisplayAlert("Congratulations", "You have successfully bought the book "+ a.title, "OK");

            Navigation.PopModalAsync();

        }
    }
}