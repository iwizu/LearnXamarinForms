﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ARelativeLayout : ContentPage
    {
        public ARelativeLayout()
        {
            InitializeComponent();
            Title = "Relative Layout";
        }
    }
}
