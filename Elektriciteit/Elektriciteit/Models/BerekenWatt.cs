namespace Elektriciteit.Models
{
    public class BerekenWatt
    {
        public BerekenWatt(double ampere, double volt)
        {
            elekModel.Ampere = ampere;
            elekModel.Volt = volt;
        }

        public BerekenWatt(double ampere, double volt, double ohm) : this(ampere, volt)
        {
            elekModel.Ohm = ohm;
        }

        public ElekModel elekModel = new ElekModel();

        public string Watt()
        {
            double result = 0;
            if (elekModel.Ohm == 0)
            {
                result = elekModel.Ampere * elekModel.Volt;
                return result.ToString();
            }
            else if (elekModel.Volt == 0)
            {
                result = elekModel.Ohm * (elekModel.Ampere * elekModel.Ampere);
                return result.ToString();
            }
            else
            {
                return "Oeps, er is iets fout gegaan";
            }
        }
    }
}
