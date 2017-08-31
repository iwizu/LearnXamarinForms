using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UniBooks
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Children.Add(
                new NavigationPage(new BrowsePage())
                {
                    Title = "Browse",
                    BarBackgroundColor = Color.FromHex("7BABED"),
                    BarTextColor = Color.FromHex("FCFCFE")                  
        });
            this.Children.Add(
                new NavigationPage(new CollectionPage())
                {
                    Title = "Collection",
                    BarBackgroundColor = Color.FromHex("7BABED"),
                    BarTextColor = Color.FromHex("FCFCFE")
                });
            this.BarTextColor = Color.FromHex("FCFCFE");
            Title = "Search for a book";

            this.CurrentPageChanged += CurrentPageHasChanged;
        }
        protected void CurrentPageHasChanged(object sender, EventArgs e) {
            this.Title = this.CurrentPage.Title;
        }

    }
}
