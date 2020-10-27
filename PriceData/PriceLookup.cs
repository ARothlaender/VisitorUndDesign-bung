using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Bundesbank.Rc1.Übungen.PriceData
{

    public class PriceLookup : IPriceLookup
    {
        //Singleton
        private static PriceLookup instance = null;
        //In Produktion kann man das Konzept "Preis" ggf. als Struct implementieren, der verschiedene
        //Preisausprägungen enthält. Hier wird erstmal angenommen, dass es eine ISIN genau einen Preis hat.
        private IDictionary<string, decimal> prices;
        public static PriceLookup PriceTable
        {
            get
            {
                if (instance == null)
                {
                    instance = new PriceLookup();
                }
                return instance;
            }
        }
       private PriceLookup()
        {
            prices = InitiatePrices();
        }
        public virtual decimal? FindPrice(string identifier)
        {
            try
            {
                return prices[identifier];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        private IDictionary<string,decimal> InitiatePrices()
        {
            //Hier DB Logik einfügen in voller Ausimplementierung
            return new Dictionary<string, decimal>
            {
                {"DE12345678",1.12m },
                {"FR12345678",0.9m },
                {"FR22345678",1.1m },
                {"US12345678",1.0m },
                {"US22345678",1.1m },
                {"US32345678",1.15m },
                {"US42345678",250m },
                {"US52345678",15.0m },
                {"US62345678",1.0m },
                {"DE22345678",1.1m },
                {"DE32345678",1.3m },
                {"DE42345678",0.02m },
                {"DE52345678",1.02m },
                {"DE62345678",0.889m },
                {"DE72345678",1.0m },
                {"DE82345678",1.65m },
                {"DE92345678",1.0645m }
            };
        }
    }
}
