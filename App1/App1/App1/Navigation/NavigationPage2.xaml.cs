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
	public partial class NavigationPage2 : ContentPage
	{
		public NavigationPage2 ()
		{
			InitializeComponent ();
		}
        public NavigationPage2(string passedValue)
        {
            InitializeComponent();
            PassedValue.Text = passedValue;
        }
        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            // Page appearance animated
            await Navigation.PopToRootAsync(true);
        }

        private void AlertBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
        }
        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            AlertAnswer.Text="Answer: " + answer;
        }
        async void OnActionSheetSimpleClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            AlertAnswer.Text = "Action: " + action;
        }
        async void OnActionSheetCancelDeleteClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
            AlertAnswer.Text = "Action: " + action;
        }
    }
}