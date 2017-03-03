using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoseChicken
{
    class Product : StackLayout
    {
        String name;
        double value;
        public Product(String nameOfProduct, double valueFfProduct)
        {
            this.name = nameOfProduct;
            this.value = valueFfProduct;
            this.BackgroundColor = Color.Silver;
            this.Padding = new Thickness(20,0,20,0);
            this.Orientation = StackOrientation.Horizontal;
            this.HorizontalOptions = LayoutOptions.FillAndExpand;
            this.Children.Add(new Label
            {
                Text = name,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.StartAndExpand
            });
            this.Children.Add(new Label
            {
                Text = "\u00A3" + value.ToString(),
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.EndAndExpand
            });
        }
    }
}
