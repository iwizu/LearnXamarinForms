using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBooks.Data;
using UniBooks.UWP;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(LocalFilePathProvider))]

namespace UniBooks.UWP
{   
        public class LocalFilePathProvider : ILocalFilePathProvider
        {
            public string GetLocalPathToFile(string fileName)
            {
                return Path.Combine(ApplicationData.Current.LocalFolder.Path, fileName);
            }
        }
}
