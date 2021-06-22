namespace Elektriciteit.Models
{
    public class BerekenKwh
    {
        public BerekenKwh(double aantalWatt, int aantalUur, int aantalDagen, double prijs)
        {
            AantalWatt = aantalWatt;
            AantalUur = aantalUur;
            AantalDagen = aantalDagen;
            Prijs = prijs;
        }

        public double AantalWatt { get; set; }
        public int AantalUur { get; set; }
        public int AantalDagen { get; set; }
        public double Prijs { get; set; }

        public string BerekeningKwh()
        {
            double result = (AantalUur * AantalDagen * (AantalWatt / 1000)) * Prijs;
            return result.ToString();
        }
    }
}
