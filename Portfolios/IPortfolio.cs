using Bundesbank.Rc1.Übungen.Instruments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Portfolios
{
    public interface IPortfolio

    {
        //public string GetPortfolioStructureInformation(Object config);
        public void AddPosition(IPosition position);
    }
}
