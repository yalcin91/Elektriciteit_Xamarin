
using Elektriciteit.Models;

using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elektriciteit.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BerekenKwhPage : ContentPage
    {
        public BerekenKwhPage()
        {
            InitializeComponent();
            LbEersteText.Text = "Voor het berekenen van aantal \nkhw/€ moet je aantal gegevens weten.\n" +
                "1) Aantal watt totaal.\n" +
                "2) +-Aantalurenin gebruik per dag. \n" +
                "3) aantal gewenste dagen. \n" +
                "4) prijs per Khw(€0.18 - €0.25),\n" +
                "   is verschillend van leverancier";
        }

        private void Check()
        {
            if (!string.IsNullOrEmpty(EnWatt.Text) && EnWatt.Text != "")
            {
                if (!string.IsNullOrEmpty(EnUur.Text) && EnUur.Text != "")
                {
                    if (!string.IsNullOrEmpty(EnDagen.Text) && EnDagen.Text != "")
                    {
                        if (!string.IsNullOrEmpty(EnPrijs.Text) && EnPrijs.Text != "")
                        {
                            BtnBereken.IsEnabled = true;
                        }
                        else BtnBereken.IsEnabled = false;
                    }
                    else BtnBereken.IsEnabled = false;
                }
                else BtnBereken.IsEnabled = false;
            }
            else BtnBereken.IsEnabled = false;
        }

        private void EnWatt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();
        }

        private void EnUur_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();

        }

        private void EnDagen_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();
        }

        private void EnPrijs_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();
        }

        private void BtnBereken_Clicked(object sender, System.EventArgs e)
        {
            BerekenKwh berekenKwh = new BerekenKwh(double.Parse(EnWatt.Text), int.Parse(EnUur.Text), int.Parse(EnDagen.Text), double.Parse(EnPrijs.Text));
            double resultaat = Math.Round(double.Parse(berekenKwh.BerekeningKwh()), 2);
            LbResultaat.Text = $"Een vermogen van {EnWatt.Text} watt die per dag ongeveer {EnUur.Text} uren in verbruik is," +
                $" heeft een totaal prijs van €{resultaat} op {EnDagen.Text} dagen totaal.";
        }
    }
}