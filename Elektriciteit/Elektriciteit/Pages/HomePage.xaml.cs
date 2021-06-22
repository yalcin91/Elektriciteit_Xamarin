
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Elektriciteit.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private double startScale;
        private double currentScale;
        private double xOffset;
        private double yOffset;

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

        private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            if (e.Status == GestureStatus.Started)
            {
                startScale = Content.Scale;
                Content.AnchorX = 0;
                Content.AnchorY = 0;
            }

            if (e.Status == GestureStatus.Running)
            {
                currentScale += (e.Scale - 1) * startScale;
                currentScale = Math.Max(1, currentScale);

                // The ScaleOrigin is in relative coordinatesto the wrapped UI element.
                double renderedX = Content.X + xOffset;
                double deltaX = renderedX / Width;
                double deltaWidth = Width / (Content.Width * startScale);
                double originX = (e.ScaleOrigin.X - deltaX) * deltaWidth;

                double renderedY = Content.Y + yOffset;
                double deltaY = renderedY / Height;
                double deltaHeight = Height / (Content.Height * startScale);
                double originY = (e.ScaleOrigin.Y - deltaY) * deltaHeight;

                // Calculate the transformed element pixel coordinates
                double targetX = xOffset - (originX * Content.Width) * (currentScale - startScale);
                double targetY = yOffset - (originY * Content.Height) * (currentScale - startScale);

                // Apply translation based on the change in origin
                Content.TranslationX = Math.Min(0, Math.Max(targetX, -Content.Width * (currentScale - 1)));
                Content.TranslationY = Math.Min(0, Math.Max(targetY, -Content.Height * (currentScale - 1)));

                // Apply scale factor
                Content.Scale = currentScale;
            }

            if (e.Status == GestureStatus.Completed)
            { // Store the deltas of the wrapped UI element
                xOffset = Content.TranslationX;
                yOffset = Content.TranslationY;
            }
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
    }
}