using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.PriceData
{
    public interface IPriceLookup
    {
        public decimal? FindPrice(string identifier);

    }
}
