using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoseChicken
{
    class MainMenu : ContentPage
    {
        TapGestureRecognizer gestureRec = new TapGestureRecognizer();

        StackLayout MainSt = new StackLayout();

        Image MainTopImage = new Image {
            Source = Device.OnPlatform(
            iOS: ImageSource.FromFile("Images/byleCo.png"),
            Android: ImageSource.FromFile("byleCo.png"),
            WinPhone: ImageSource.FromFile("Images/byleCo.png")),
        Aspect = Aspect.AspectFit
            //MinimumWidthRequest = 100
        };

        Grid MainGrid = new Grid();
        private NavigationPage navPage;

        internal MainMenu()
        {
            SetUp();
        }
        public MainMenu(NavigationPage navPage)
        {
            this.navPage = navPage;
            this.SetUp();
        }
        private void SetUp()
        {
            setUpMainSt();
            setUpMainGrid();
            this.Content = MainSt;
        }
        private void setUpMainSt()
        {
            MainSt.Children.Add(MainTopImage);
            MainSt.Children.Add(MainGrid);
            this.MainSt.VerticalOptions = LayoutOptions.FillAndExpand;
        }

        void setUpMainGrid()
        {
            MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            Image lewyGorny = new Image
            {
                Source = ImageSource.FromFile("byleCo.png"),
                StyleId = "lewyGorny"
            };
            Image prawyGorny = new Image
            {
                Source = ImageSource.FromFile("danieDnia.png"),
                StyleId = "prawyGorny"
            };
            Image lewyDolny = new Image
            {
                Source = ImageSource.FromFile("byleCo.png"),
                StyleId = "lewyDolny"
            };
            Image prawyDolny = new Image
            {
                Source = ImageSource.FromFile("ContactUs2.png"),
                StyleId = "prawyDolny"
            };
            gestureRec.Tapped += GestureRec_Tapped;
            lewyGorny.GestureRecognizers.Add(gestureRec);
            prawyGorny.GestureRecognizers.Add(gestureRec);
            lewyDolny.GestureRecognizers.Add(gestureRec);
            prawyDolny.GestureRecognizers.Add(gestureRec);
            MainGrid.Children.Add(lewyGorny, 0, 0);
            MainGrid.Children.Add(lewyDolny, 0, 1);
            MainGrid.Children.Add(prawyGorny, 1, 0);
            MainGrid.Children.Add(prawyDolny, 1, 1);
            MainGrid.VerticalOptions = LayoutOptions.FillAndExpand;
        }

        private void GestureRec_Tapped(object sender, EventArgs e)
        {
            String StyleID = ((Image)sender).StyleId.ToString();
            if (StyleID.Equals("prawyGorny"))
            {
                Navigation.PushAsync(new Offers());
            }
            else if (StyleID.Equals("prawyDolny"))
            {
                Navigation.PushAsync(new ContactUs());
            }
        }
        
    }
}
