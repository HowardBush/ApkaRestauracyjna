using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoseChicken
{
    class ContactUs : ContentPage
    {
        public ContactUs()
        {
            this.Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    new Label
                    {
                        Text = "Yellow@Cow.com",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    },
                    new Label
                    {
                        Text = "Phone: " + "0 123 45 67 98",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    },
                    new Image
                    {
                        Source = ImageSource.FromFile("FbSign.png"),
                    }
                }
            };
            TapGestureRecognizer gesture = new TapGestureRecognizer();
            gesture.Tapped += Gesture_Tapped;
            ((Image)(((StackLayout)this.Content).Children.ElementAt(2))).GestureRecognizers.Add(gesture);

        }

        private void Gesture_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FbWebPage());
        }
    }
}
