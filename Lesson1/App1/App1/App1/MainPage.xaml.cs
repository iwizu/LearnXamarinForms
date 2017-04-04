﻿using App1.Layouts;
using App1.Pages;
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
    }
}