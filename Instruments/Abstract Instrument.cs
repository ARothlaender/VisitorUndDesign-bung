using Bundesbank.Rc1.Übungen.PriceData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Instruments
{
    public abstract class AbstractInstrument : IInstrument
    {
        public String Issuer { get; protected set; }
        public String ISIN { get; protected set; }
        public string Currency { get; protected set; }
        public String Rating { get; set; }

        public virtual decimal Evaluate() 
        {
            return Evaluate(PriceLookup.PriceTable);
        }
        public virtual decimal Evaluate(IPriceLookup priceData)
        {
            decimal? marketPrice = priceData.FindPrice(this.ISIN);
            return marketPrice != null ? (decimal)marketPrice : CalculatePrice();
        }
        protected virtual decimal CalculatePrice()
        {
            return 1.0m;
        }

       

        public AbstractInstrument(string issuer,string isin, string rating, string currency)
        {
            Issuer = issuer;
            ISIN = isin;
            Rating = rating;
            Currency = currency;
        }
        
    }
}
