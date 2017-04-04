using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AMasterDetailPageMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public AMasterDetailPageMaster()
        {
            InitializeComponent();
            BindingContext = new AMasterDetailPageMasterViewModel();
        }



        class AMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AMasterDetailPageMenuItem> MenuItems { get; }
            public AMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<AMasterDetailPageMenuItem>(new[]
                {
                    new AMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new AMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new AMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new AMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new AMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
