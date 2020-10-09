using Bundesbank.Rc1.Übungen.PriceData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Instruments
{
    public class EquityInstrument : AbstractInstrument
    {
        public EquityInstrument(string issuer, string isin, string rating, string currency) : base(issuer, isin, rating, currency)
        {

        }
    }
}
