namespace Elektriciteit.Models
{
    public class Kabel
    {
        public string Naam { get; set; }
        public string ImageNaam { get; set; }
        public string Detail { get; set; }

        public string GetKabel(string naam)
        {
            Naam = naam;
            if (Naam == "COAX")
            {
                Detail = "Een coax kabel (ook wel coaxiale kabel genoemd) bestaat uit een afgeschermde centrale geleider met daarrond een tweede geleider. " +
                         "Omdat de assen van beide geleiders samenvallen, zijn er weinig tot geen stoorsignalen. " +
                         "Coax wordt het meest frequent gebruikt voor televisiesignalen.";
                return Detail;
            }
            else if (Naam == "CTMB")
            {
                Detail = "CTMB is een kabel met verschillende aders (van 2 tot 12) die beschermd worden door een rubber omhulsel. " +
                         "Hierdoor is de kabel vochtbestendig. CTMB wordt gebruikt voor de aansluiting van kookplaten, sauna’s, werfkabels (tussen 1,5mm en 6mm), enz.";
                return Detail;
            }
            else if (Naam == "VOB")
            {
                Detail = "Een VOB is een losse elektriciteitsdraad die verkrijgbaar is in verschillende kleuren en gebruikt wordt voor diverse functies. " +
                         "Zo gebruikt men een VOB geel-groen voor equipotentiale verbindingen. " +
                         "Losse VOB draden komen ook van pas in de zekeringskast. " +
                         "Indien deze draden in een wand of beton gebruikt worden, is een preflex bescherming nodig om aantasting van de draden te vermijden.";
                return Detail;
            }
            else if (Naam == "VOBst")
            {
                Detail = "Een VOBst is een variant van de VOB. " +
                         "Deze elektriciteitsdraad is veel soepeler dan de VOB. " +
                         "De VOBst bestaat uit een meerdradige kern van vertind koper.";
                return Detail;
            }
            else if (Naam == "SVV")
            {
                Detail = "Een SVV wordt ook wel signaalkabel genoemd. " +
                         "Ze is perfect geschikt voor het verzenden en ontvangen van stuursignalen, bijvoorbeeld voor domotica, een parlofoon, videofoon, enz. " +
                         "Bovendien wordt ze gebruikt voor het aansturen van teleruptoren op laagspanning.";
                return Detail;
            }
            else if (Naam == "VTLMB")
            {
                Detail = "VTLMB is beter bekend als een luidsprekerkabel. " +
                    "Deze kabel is tevens geschikt voor de aansluiting van kleine elektrische huishoudapparaten.";
                return Detail;
            }
            else if (Naam == "VVT")
            {
                Detail = "VVT is een telefoniekabel voor binneninstallaties. De draden worden samengedraaid per paar.";
                return Detail;
            }
            else if (Naam == "XVB")
            {
                Detail = "XVB bestaat uit een reeks VOB draden die beschermd worden door een kunststof omhulsel. " +
                         "Deze kabels worden gebruikt voor de binneninstallatie.";
                return Detail;
            }
            else if (Naam == "EXVB")
            {
                Detail = "Daarnaast is er nog een EXVB kabel, welke een extra stevig omhulsel heeft. " +
                         "EXVB is de kabel die stroom van de openbare hoofdleiding naar je woning brengt.";
                return Detail;
            }
            else return Detail = "Oops, er is iets mis gegaan";
        }
    }
}
