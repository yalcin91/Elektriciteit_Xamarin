namespace Elektriciteit.Models
{
    public class BerekenVolt
    {
        public BerekenVolt(double ampere, double ohm)
        {
            elekModel.Ohm = ohm;
            elekModel.Ampere = ampere;
        }

        public BerekenVolt(double ampere, double ohm, double watt) : this(ampere, ohm)
        {
            elekModel.Watt = watt;
        }

        public ElekModel elekModel = new ElekModel();

        public string Spanning()
        {
            double result = 0;
            if (elekModel.Ohm == 0)
            {
                result = elekModel.Watt / elekModel.Ampere;
                return result.ToString();
            }
            else if (elekModel.Watt == 0)
            {
                result = elekModel.Ampere * elekModel.Ohm;
                return result.ToString();
            }
            else
            {
                return "Oeps, er is iets fout gegaan";
            }
        }
    }
}
