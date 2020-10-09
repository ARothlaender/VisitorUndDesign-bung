using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Instruments
{
    public class CashInstrument : AbstractInstrument
    {
        public string AccountNumber { get;}
        public CashInstrument(string issuer, string isin, string rating, string currency, string accountnumber) : base(issuer, isin, rating, currency)
        {
            AccountNumber = accountnumber;
        }

        public override decimal Evaluate()
        {
            return 1.0m;
        }
    }
}
