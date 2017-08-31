using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniBooks.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace UniBooks
{
    public partial class App : Application
    {
        public static GoogleBooksService BooksServiceManager { get; set; }
       
        private static BooksDataAccess _database;
        public static BooksDataAccess Database => GetDatabase();

        private static BooksDataAccess GetDatabase()
        {
            if (_database == null)
            {
                _database = new BooksDataAccess("Database.db3");
            }

            return _database;
        }

        public App()
        {
            InitializeComponent();
            BooksServiceManager = new GoogleBooksService();
            
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
