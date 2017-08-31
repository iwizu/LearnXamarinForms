using App1.Animations;
using App1.Bindings;
using App1.Controls;
using App1.Layouts;
using App1.Navigation;
using App1.Pages;
using App1.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Welcome to X.Forms samples";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          Navigation.PushAsync(new AContentPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutsMenu());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AControlsPage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingsPage());

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StylePage());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnimationPage());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage1());
        }
    }
}
