namespace Elektriciteit.Models
{
    public class BerekenKwh
    {
        public double AantalWatt { get; set; }
        public int AantalUur { get; set; }
        public int AantalDagen { get; set; }
        public double Prijs { get; set; }

        public double BerekeningKwh()
        {
            double result = AantalUur * AantalDagen * (AantalWatt / 1000);
            return result * Prijs;
        }
    }
}
