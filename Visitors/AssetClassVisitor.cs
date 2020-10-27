using Bundesbank.Rc1.Übungen.Portfolios;
using System;
using System.Collections.Generic;
using System.Text;
using VisitorUndDesignübung.Portfolios.PortfolioInformationObjects;

namespace VisitorUndDesignübung.Visitors
{
    public class AssetClassVisitor : AbstractPositionVisitor
    {
        private Dictionary<string, decimal> assetClassInfo;
        private decimal totalMarketValue;


        public AssetClassVisitor()
        {

        }

        public override void Initiate()
        {
            assetClassInfo = new Dictionary<string, decimal>();
            totalMarketValue = 0;
        }


        public override void Visit(IPosition position)
        {
            totalMarketValue += position.MarketValue;
            //Das gefällt mir noch nicht idk... vlt. alle Struktur Visitor in eine gemeinsame Superklasse stecken
            //dann spart man sich Codedopplung aber es wird halt mega unübersichtlich....
            if (assetClassInfo.ContainsKey(position.Instrument.GetType().Name))
            {
                assetClassInfo[position.Instrument.GetType().Name] += position.MarketValue;
            }
            else
            {
                assetClassInfo.Add(position.Instrument.GetType().Name, position.MarketValue);
            }

        }

        public override void Finish()
        {
            assetClassInfo.Add("Total", totalMarketValue);
        }
        public IPortfolioInformationObject GetAssetStructureInformation()
        {
            return new PortfolioAssetStructureInformation(assetClassInfo); 
        }

    }
}
