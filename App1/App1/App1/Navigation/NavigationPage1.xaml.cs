using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationPage1 : ContentPage
	{
		public NavigationPage1 ()
		{
			InitializeComponent ();
		}

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage2("Passed string!"));
        }
        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}