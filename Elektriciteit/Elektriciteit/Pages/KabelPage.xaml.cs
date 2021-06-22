using Elektriciteit.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elektriciteit.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KabelPage : ContentPage
    {
        public KabelPage(string naam, string image)
        {
            InitializeComponent();
            GetNaamEnImage(naam, image);
        }

        private void GetNaamEnImage(string naam, string image)
        {
            Kabel kabel = new Kabel();
            var detail = kabel.GetKabel(naam);
            LblDetail.Text = detail;
            imageNaam.Source = image;
        }
    }
}