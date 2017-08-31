using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.Runtime.CompilerServices;
using UniBooks.iOS;
using UniBooks.Data;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinIOS;

[assembly: Xamarin.Forms.Dependency(typeof(SqlitePlatformProvider))]
namespace UniBooks.iOS
{
    public class SqlitePlatformProvider : ISqlitePlatformProvider
    {
        public ISQLitePlatform GetPlatform()
        {
            return new SQLitePlatformIOS();
        }
    }
}