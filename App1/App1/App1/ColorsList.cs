using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{   
    public static class ColorsList
    {
        public static readonly Color ForegroundColor =
           Device.OnPlatform(Color.Black, Color.White, Color.Blue);
    }
}
