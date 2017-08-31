using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
namespace App1.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AControlsPage : ContentPage
    {
        public AControlsPage()
        {
            InitializeComponent();
            DateCtrl.Date = DateTime.Now;
            ImageCtr.Source = ImageSource.FromUri(new Uri("http://www.uom.gr/themes/UOM3/images/pamak-front-ell-header.jpg"));
            LabelText.Text = "test value";
            ListValues = new List<ListValue>
            {
                new ListValue{ Text="Text1",Val="Val1" },
                new ListValue{ Text="Text2",Val="Val2" },
                new ListValue{ Text="Text3",Val="Val3" }
            };
            ListViewCtr.ItemsSource = ListValues;
             UrlWebViewSource u = new UrlWebViewSource();
            u.Url = "https://developer.xamarin.com/api/type/Xamarin.Forms.WebView/";
            WebViewCtr.Source = u;
        }
        public List<ListValue> ListValues { get; set; }
        public class ListValue
        {
            public string Text { get; set; }
            public string Val { get; set; }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ButtonLabel.Text = "Thank you";
        }

        private void DateCtrl_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateSelected.Text = e.NewDate.ToString();
        }

        private void EditorCtr_TextChanged(object sender, TextChangedEventArgs e)
        {
            EditorText.Text = e.NewTextValue;
        }

        private void EntryCtr_TextChanged(object sender, TextChangedEventArgs e)
        {
            EntryText.Text = e.NewTextValue;
        }

        private void ListViewCtr_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itm = e.SelectedItem as ListValue;
            ListViewText.Text ="Selected item="+itm.Text+" "+itm.Val;
        }

        private void PickerCtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickerText.Text = PickerCtr.Items[PickerCtr.SelectedIndex];
        }

        private void SliderCtr_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderText.Text = e.NewValue.ToString();
        }

        private void StepperCtr_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            StepperText.Text = e.NewValue.ToString();
        }

        private void SwitchCtr_Toggled(object sender, ToggledEventArgs e)
        {
            SwitchText.Text = e.Value.ToString();
        }
        
    }
}