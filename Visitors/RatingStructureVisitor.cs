using Bundesbank.Rc1.Übungen.Portfolios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisitorUndDesignübung.Portfolios.PortfolioInformationObjects;

namespace VisitorUndDesignübung.Visitors
{
    public class RatingStructureVisitor : AbstractPositionVisitor
    {
        private Dictionary<string, decimal> ratingInfo;
        private string visitedPortfolio = "Unknown";
        private decimal totalMarketValue;
        
        public RatingStructureVisitor()
        {

        }

        public RatingStructureVisitor(string visitedPortfolio)
        {
            //vlt. sollte man den Namen des besuchten Portfolios noch durchziehen bis ins Information Object
            this.visitedPortfolio = visitedPortfolio;
        }

        public override void Initiate()
        {
            ratingInfo = new Dictionary<string, decimal>();
            totalMarketValue = 0;
        }
        public override void Visit(IPosition position)
        {
            totalMarketValue += position.MarketValue;
            //Erster Aufschlag, position.Instrument.Rating kann man noch refactorn.
            if (ratingInfo.ContainsKey(position.Instrument.Rating))
            {
                ratingInfo[position.Instrument.Rating] += position.MarketValue;
            }
            else
            {
                ratingInfo.Add(position.Instrument.Rating, position.MarketValue);
            }
           
        }

        public override void Finish()
        {
            if (ratingInfo.Count == 0) Console.WriteLine($"Achtung! Portfolio {visitedPortfolio} wurde leer übergeben");
            SortInfo();
            ratingInfo.Add("Total", totalMarketValue);
        }

        private void SortInfo()
        {
            ratingInfo = ratingInfo.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);
        }

        public IPortfolioInformationObject GetPortfolioRatingInformation()
        {
            return new PortfolioRatingInformation(ratingInfo);
        }
    }
}
