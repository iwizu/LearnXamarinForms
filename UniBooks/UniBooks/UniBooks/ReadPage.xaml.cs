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
    public partial class ReadPage : ContentPage
    {
        private ABook book;
        public ABook Book
        {
            get { return book; }
            set
            {
                book = value;
            }
        }

        public ReadPage(ABook book)
        {
            InitializeComponent();
            Title = "Book Reader";
            Book = book;
            this.BindingContext = this;
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}