
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Elektriciteit.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {        
        public HomePage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped_Ohm(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BerekenOhmPage());
        }

        private async void TapGestureRecognizer_Tapped_Stroom(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BerekenAmperePage());
        }

        private async void TapGestureRecognizer_Tapped_Volt(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BerekenVoltPage());
        }

        private async void TapGestureRecognizer_Tapped_Khw(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BerekenKwhPage());
        }

        private async void TapGestureRecognizer_Tapped_Watt(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BerekenWattPage());
        }

        private async void TapGestureRecognizer_Tapped_Coax(object sender, EventArgs e)
        {
            string naam = "COAX";
            string image = "coax.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_Ctmb(object sender, EventArgs e)
        {
            string naam = "CTMB";
            string image = "CTMB.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_Vob(object sender, EventArgs e)
        {
            string naam = "VOB";
            string image = "VOB.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_VobSt(object sender, EventArgs e)
        {
            string naam = "VOBst";
            string image = "VOBst.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_Svv(object sender, EventArgs e)
        {
            string naam = "SVV";
            string image = "SVV.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_VTLMB(object sender, EventArgs e)
        {
            string naam = "VTLMB";
            string image = "VTLMB.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_VVT(object sender, EventArgs e)
        {
            string naam = "VVT";
            string image = "VVT.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_XVB(object sender, EventArgs e)
        {
            string naam = "XVB";
            string image = "XVB.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_EXVB(object sender, EventArgs e)
        {
            string naam = "EXVB";
            string image = "EXVB.png";
            await Navigation.PushModalAsync(new KabelPage(naam, image));
        }

        private async void TapGestureRecognizer_Tapped_Menu(object sender, EventArgs e)
        {
            GridOverlay.IsVisible = true;
            await SlMenu.TranslateTo(0, 0, 400, Easing.Linear);
        }

        private async void TapCloseMenu_Tapped_CloseMenu(object sender, EventArgs e)
        {
            await SlMenu.TranslateTo(-250, 0, 400, Easing.Linear);
            GridOverlay.IsVisible = false;
        }

        private async void TapGestureRecognizer_Tapped_TabelKabel(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabelKabelPage());
        }

        private async void TapGestureRecognizer_Tapped_TabelWetVanOhm(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabelWetVanOhmPage());
        }

        private async void TapGestureRecognizer_Tapped_TabelWeertsand(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabelWeerstand());
        }
    }
}