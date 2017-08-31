using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Bindings
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BindingsPage : ContentPage
	{
        public string BindingString { get; set; }
		public BindingsPage ()
		{
			InitializeComponent ();
            BindingString = "A String from code behing";
            BindingContext = this;
        }
	}
}