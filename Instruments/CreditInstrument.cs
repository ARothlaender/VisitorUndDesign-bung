using Bundesbank.Rc1.Übungen.PriceData;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Instruments
{
    public class CreditInstrument : AbstractInstrument
    {
        public CreditInstrument(string issuer, string isin, string rating, string currency) : base(issuer, isin, rating, currency)
        {
        }

        public string DayCount { get; set; }

        protected override decimal CalculatePrice()
        {
            // zu Demozwecken
            return 0.5m;
        }

    }
}
