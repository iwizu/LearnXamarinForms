using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AContentPage : ContentPage
    {
        public AContentPage()
        {
            InitializeComponent();
            Title = "Pages (this is a ContentPage)"; 
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AMasterDetailPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ATabbedPage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ACarouselPage());
        }
    }
}
