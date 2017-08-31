using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Animations
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnimationPage : ContentPage
	{
        uint duration = 2000;

        public AnimationPage ()
		{
			InitializeComponent ();
            
        }

        public async void RunAnimation()
        {

            await Task.WhenAll(
              AnimationLabel.RotateXTo(251 * 360, duration),
              AnimationLabel.RotateYTo(199 * 360, duration)
            );
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            AnimationLabel.RotateTo(360, duration);          
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            AnimationLabel.RelRotateTo(360, duration);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            AnimationLabel.ScaleTo(2, duration);
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            AnimationLabel.RelScaleTo(2, duration);
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            AnimationLabel.AnchorY = (Math.Min(this.Width, this.Height) / 2) / AnimationLabel.Height;
            AnimationLabel.RotateTo(360, duration);
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            AnimationLabel.TranslateTo(-100, -100, duration);
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            AnimationLabel.FadeTo(0, 4000);
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            AnimationLabel.RotateXTo(251 * 360, duration);
        }
    }
}