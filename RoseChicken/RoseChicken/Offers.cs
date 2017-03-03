using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoseChicken
{
    class Offers : ContentPage
    {
        internal Offers()
        {
            this.Content =
                new ScrollView
                {
                    Content = 
                    new StackLayout()
                    {
                        VerticalOptions = LayoutOptions.Start,
                        BackgroundColor = Color.White,
                        Children =
                        {
                            new Label
                            {
                                Text = "FISH",
                                FontSize = 24,
                                TextColor = Color.Teal
                            },
                            new Product("Cod", 3.95),
                            new Product("Cod Supper", 6.50),
                            new Product("Scampi", 3.95),

                            new Label
                            {
                                Text = "CHIPS",
                                FontSize = 24,
                                TextColor = Color.Teal
                            },
                            new Product("Small Chip", 2.10),
                            new Product("Chip", 2.70),
                            new Product("Gravy Chip", 3.50),

                            new Label
                            {
                                Text = "SUPPERS",
                                FontSize = 24,
                                TextColor = Color.Teal
                            },
                            new Product("Cod Supper", 6.50),
                            new Product("Sousage Supper", 4.60),
                            new Product("Battered Sausage Supper", 4.70),

                            new Label
                            {
                                Text = "CHICKEN",
                                FontSize = 24,
                                TextColor = Color.Teal
                            },
                            new Product("Chicken Breast", 3.40),
                            new Product("Spicy Wings", 3.50),
                            new Product("Nuggets", 3.60),

                            new Label
                            {
                                Text = "VARIOUS",
                                FontSize = 24,
                                TextColor = Color.Teal
                            },
                            new Product("Sausage", 0.95),
                            new Product("Battered Sausage", 1.00),
                            new Product("Homemade pastie", 1.90),
                            new Product("Hot Dog", 2.30),
                            new Product("Steakette", 2.10),
                            new Product("Scallops", 2.40),
                        }
                    }
                };
           
                
            
        }
        
    }
}
