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
using System.IO;
using UniBooks.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(LocalFilePathProvider))]

namespace UniBooks.Droid
{
    public class LocalFilePathProvider : ILocalFilePathProvider
    {
        public string GetLocalPathToFile(string fileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), fileName);
        }
    }
}