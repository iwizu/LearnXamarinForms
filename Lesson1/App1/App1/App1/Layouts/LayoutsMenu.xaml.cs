using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutsMenu : ContentPage
    {
        public LayoutsMenu()
        {
            InitializeComponent();
            Title = "Layouts Menu";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AStackLayout());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AAbsoluteLayout());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ARelativeLayout());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AGridLayout());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AContentView());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AScrollView());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AFrame());
        }
    }
}
