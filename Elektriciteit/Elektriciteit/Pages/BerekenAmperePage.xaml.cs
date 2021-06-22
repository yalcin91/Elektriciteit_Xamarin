
using Elektriciteit.Models;

using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elektriciteit.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BerekenAmperePage : ContentPage
    {
        public BerekenAmperePage()
        {
            InitializeComponent();
        }

        private void Check()
        {
            if (EnVolt.Text == "0")
            {
                EnVolt.Text = "";
            }
            if (EnVolt.Text != "")
            {
                if (!string.IsNullOrEmpty(EnWatt.Text) && EnWatt.Text != "")
                {
                    BtnBereken.IsEnabled = true;
                }
                else if (!string.IsNullOrEmpty(EnOhm.Text) && EnOhm.Text != "")
                {
                    BtnBereken.IsEnabled = true;
                }
                else BtnBereken.IsEnabled = false;
            }
            else BtnBereken.IsEnabled = false;
        }

        private void EnOhm_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EnOhm.Text == "0")
            {
                EnOhm.Text = "";
            }
            if (EnOhm.Text != "") { EnWatt.IsEnabled = false; }
            if (EnOhm.Text == "") { EnWatt.IsEnabled = true; }
            Check();
        }

        private void EnWatt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EnWatt.Text == "0")
            {
                EnWatt.Text = "";
            }
            if (EnWatt.Text != "") { EnOhm.IsEnabled = false; }
            if (EnWatt.Text == "") { EnOhm.IsEnabled = true; }
            Check();
        }

        private void EnVolt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();
        }

        private void BtnBereken_Clicked(object sender, EventArgs e)
        {
            double watt = 0;
            double ohm = 0;
            if (EnWatt.Text == "" || string.IsNullOrEmpty(EnWatt.Text)) { watt = 0; } else watt = double.Parse(EnWatt.Text);
            if (EnOhm.Text == "" || string.IsNullOrEmpty(EnOhm.Text)) { ohm = 0; } else ohm = double.Parse(EnOhm.Text);
            var volt = double.Parse(EnVolt.Text);
            //var volt = double.Parse(EnVolt.Text);            
            //var ohm = double.Parse(EnOhm.Text);  
            BerekenAmpere berekenAmpere = new BerekenAmpere(volt, watt, ohm);
            double resultaat = Math.Round(double.Parse(berekenAmpere.Ampere()), 2);
            LbResultaat.Text = $"Het aantal stroom is: {resultaat} ampere";
        }
    }
}