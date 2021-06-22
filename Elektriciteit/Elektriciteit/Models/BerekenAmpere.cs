namespace Elektriciteit.Models
{
    public class BerekenAmpere
    {
        public BerekenAmpere(double volt, double watt)
        {
            elekModel.Watt = watt;
            elekModel.Volt = volt;
        }

        public BerekenAmpere(double volt, double watt, double ohm) : this(volt, watt)
        {
            elekModel.Ohm = ohm;
        }

        public ElekModel elekModel = new ElekModel();

        public string Ampere()
        {
            double result = 0;
            if (elekModel.Watt == 0)
            {
                result = elekModel.Volt / elekModel.Ohm;
                return result.ToString();
            }
            else if (elekModel.Ohm == 0)
            {
                result = elekModel.Watt / elekModel.Volt;
                return result.ToString();
            }
            else
            {
                return "Oeps, er is iets fout gegaan";
            }
        }
    }
}
