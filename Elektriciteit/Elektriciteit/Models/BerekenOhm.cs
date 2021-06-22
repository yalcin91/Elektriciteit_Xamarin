namespace Elektriciteit.Models
{
    public class BerekenOhm
    {
        public BerekenOhm(double volt, double ampere)
        {
            elekModel.Ampere = ampere;
            elekModel.Volt = volt;
        }

        public BerekenOhm(double volt, double ampere, double watt) : this(volt, ampere)
        {
            elekModel.Watt = watt;
        }

        public ElekModel elekModel = new ElekModel();

        public string Ohm()
        {
            double result = 0;
            if (elekModel.Watt == 0)
            {
                result = elekModel.Volt / elekModel.Ampere;
                return result.ToString();
            }
            else if (elekModel.Volt == 0)
            {
                result = elekModel.Watt / (elekModel.Ampere * elekModel.Ampere);
                return result.ToString();
            }
            else
            {
                return "Oeps, er is iets fout gegaan";
            }
        }
    }
}
