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
    public partial class AGridLayout : ContentPage
    {
        public AGridLayout()
        {
            InitializeComponent();
            Title = "Grid Layout";
        }
    }
}
