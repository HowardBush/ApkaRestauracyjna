using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoseChicken
{
    class FbWebPage : ContentPage
    {
        public FbWebPage()
        {
            this.Content = new WebView
            {
                Source = "https://www.facebook.com/mariusz.design/?fref=nf"
            };
        }
    }
}
