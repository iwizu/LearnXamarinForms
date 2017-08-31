using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.Runtime.CompilerServices;
using UniBooks.iOS;
using System.IO;
using UniBooks.Data;

[assembly: Xamarin.Forms.Dependency(typeof(LocalFilePathProvider))]
namespace UniBooks.iOS
{
    public class LocalFilePathProvider : ILocalFilePathProvider
    {
        public string GetLocalPathToFile(string fileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), fileName);
        }
    }
}