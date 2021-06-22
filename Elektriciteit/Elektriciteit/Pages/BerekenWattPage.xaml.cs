using Elektriciteit.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elektriciteit.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BerekenWattPage : ContentPage
    {
        public BerekenWattPage()
        {
            InitializeComponent();
        }

        private void Check()
        {
            if (EnAmpere.Text == "0" )
            {
                EnAmpere.Text = "";
            }
            if (EnAmpere.Text != "")
            {
                if (!string.IsNullOrEmpty(EnVolt.Text) && EnVolt.Text != "")
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
            if (EnOhm.Text != "") { EnVolt.IsEnabled = false; }
            if (EnOhm.Text == "") { EnVolt.IsEnabled = true; }
            Check();
        }

        private void EnVolt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EnVolt.Text == "0")
            {
                EnVolt.Text = "";
            }
            if (EnVolt.Text != "") { EnOhm.IsEnabled = false; }
            if (EnVolt.Text == "") { EnOhm.IsEnabled = true; }
            Check();
        }

        private void EnAmpere_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();
        }

        private void BtnBereken_Clicked(object sender, EventArgs e)
        {
            double volt = 0;
            double ohm = 0;
            if (EnVolt.Text == "" || string.IsNullOrEmpty(EnVolt.Text)) { volt = 0; } else volt = double.Parse(EnVolt.Text);
            if (EnOhm.Text == "" || string.IsNullOrEmpty(EnOhm.Text)) { ohm = 0; } else ohm = double.Parse(EnOhm.Text);
            var ampere = double.Parse( EnAmpere.Text);
            //var volt = double.Parse(EnVolt.Text);            
            //var ohm = double.Parse(EnOhm.Text);  
            BerekenWatt berekenWatt = new BerekenWatt(ampere, volt,ohm);
            var resultaat =  Math.Round(double.Parse(berekenWatt.Watt()), 2);
            LbResultaat.Text = $"De aantal vermogen is: {resultaat} watt";
        }
    }
}