using SQLite.Net.Interop;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBooks.Data;
using UniBooks.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqlitePlatformProvider))]
namespace UniBooks.UWP
{
    public class SqlitePlatformProvider : ISqlitePlatformProvider
    {
        public ISQLitePlatform GetPlatform()
        {
            return new SQLitePlatformWinRT();
        }
    }
}
