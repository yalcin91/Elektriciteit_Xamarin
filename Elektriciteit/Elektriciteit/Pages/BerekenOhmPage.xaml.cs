
using Elektriciteit.Models;

using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elektriciteit.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BerekenOhmPage : ContentPage
    {
        public BerekenOhmPage()
        {
            InitializeComponent();
        }

        private void Check()
        {
            if (EnAmpere.Text == "0")
            {
                EnAmpere.Text = "";
            }
            if (EnAmpere.Text != "")
            {
                if (!string.IsNullOrEmpty(EnVolt.Text) && EnVolt.Text != "")
                {
                    BtnBereken.IsEnabled = true;
                }
                else if (!string.IsNullOrEmpty(EnWatt.Text) && EnWatt.Text != "")
                {
                    BtnBereken.IsEnabled = true;
                }
                else BtnBereken.IsEnabled = false;
            }
            else BtnBereken.IsEnabled = false;
        }

        private void EnWatt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EnWatt.Text == "0")
            {
                EnWatt.Text = "";
            }
            if (EnWatt.Text != "") { EnVolt.IsEnabled = false; }
            if (EnWatt.Text == "") { EnVolt.IsEnabled = true; }
            Check();
        }

        private void EnVolt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EnVolt.Text == "0")
            {
                EnVolt.Text = "";
            }
            if (EnVolt.Text != "") { EnWatt.IsEnabled = false; }
            if (EnVolt.Text == "") { EnWatt.IsEnabled = true; }
            Check();
        }

        private void EnAmpere_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();
        }

        private void BtnBereken_Clicked(object sender, EventArgs e)
        {
            double volt = 0;
            double watt = 0;
            if (EnVolt.Text == "" || string.IsNullOrEmpty(EnVolt.Text)) { volt = 0; } else volt = double.Parse(EnVolt.Text);
            if (EnWatt.Text == "" || string.IsNullOrEmpty(EnWatt.Text)) { watt = 0; } else watt = double.Parse(EnWatt.Text);
            var ampere = double.Parse(EnAmpere.Text);
            //var volt = double.Parse(EnVolt.Text);            
            //var ohm = double.Parse(EnOhm.Text);  
            BerekenOhm berekenWatt = new BerekenOhm(ampere, volt, watt);
            var resultaat = Math.Round(double.Parse(berekenWatt.Ohm()), 2);
            LbResultaat.Text = $"De aantal weerstand is: {resultaat} ohm";
        }
    }
}