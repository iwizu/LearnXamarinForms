using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UniBooks.Data;
using UniBooks.Droid;
using System.Runtime.CompilerServices;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency(typeof(SqlitePlatformProvider))]
namespace UniBooks.Droid
    {
        public class SqlitePlatformProvider : ISqlitePlatformProvider
        {
            public ISQLitePlatform GetPlatform()
            {
                return new SQLitePlatformAndroid();
            }
        }
    }