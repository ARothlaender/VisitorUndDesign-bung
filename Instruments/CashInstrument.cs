using Bundesbank.Rc1.Übungen.PriceData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Instruments
{
    public class CashInstrument : AbstractInstrument
    {
        public string AccountNumber { get;}
        private string rating;
        //Hides inherited abstract member
        new public String Rating { get => "Not rated because Cash"; set => rating = Rating;}
        public CashInstrument(string issuer, string isin, string rating, string currency, string accountnumber) : base(issuer, isin, rating, currency)
        {
            AccountNumber = accountnumber;
        }


        public override decimal Evaluate(IPriceLookup priceLookup)
        {
            //Hier wird de facto auch die Evaluate Methode ohne Parameter mit 
            //überschrieben, was zwar gewünscht ist aber ggf. von außen nicht 
            //erkennbar.
            return 1.0m;
        }
    }
}
