using Bundesbank.Rc1.Übungen.Instruments;
using System;
using System.Collections.Generic;
using System.Text;
using VisitorUndDesignübung.Visitors;

namespace Bundesbank.Rc1.Übungen.Portfolios
{
    public class Portfolio : IPortfolio
    {
        private IList<IPosition> Positions { get; set; }
        public string Name { get; private set; }

        public Portfolio(string name)
        {
            Name = name;
            Positions = new List<IPosition>();
        }

        //public List<IPortfolioInformationObject> portfolioInfo;


        //Object config um in einem nächsten Schritt konfigurieren zu können, welche Informationen ausgegeben werden sollen
        //public string GetPortfolioStructureInformation(Object config)
        //{
        //    return GetRatingStructureInformation() + GetAssetClassInformation() + GetRatingPerAssetClassInformation() + GetLargestIssuer();

        //}


        //Rückgabetyp PortfolioInformationObject
        public IPortfolioInformationObject GetRatingStructureInformation()
        {
            //  Aufteilung nach Ratingklassen
            RatingStructureVisitor visitor = new RatingStructureVisitor();

            RunVisitor(visitor);

            return visitor.GetPortfolioRatingInformation();

        }

        public IPortfolioInformationObject GetAssetClassInformation()
        {
            //Aufteilung in Cash, Credit und Equity Instrumente
            AssetClassVisitor visitor = new AssetClassVisitor();

            RunVisitor(visitor);

            return visitor.GetAssetStructureInformation();
        }
        public IPortfolioInformationObject GetRatingPerAssetClassInformation()
        {
            //Aufteilung nach Ratingklassen und Assetklassen
            throw new NotImplementedException();
        }
        public IPortfolioInformationObject GetLargestIssuer()
        {
            //Aufteilung nach Issuern
            throw new NotImplementedException();
        }

        private void RunVisitor(IPositionVisitor visitor)
        {
            visitor.Initiate();

            foreach (var position in Positions)
            {
                position.accept(visitor);
            }

            visitor.Finish();
        }

        public void AddPosition(IPosition position)
        {
            Positions.Add(position);
        }
        public void PrintPositions()
        {
            foreach (IPosition pos in Positions)
            {
                Console.WriteLine(pos.ToString());
            }
        }
        public void PrintAvailablePortfolioInformation()
        {
            //wenn man eine Liste umsetzt die alle infos hält mit foreach lösen    
            Console.WriteLine(GetRatingStructureInformation());
            Console.WriteLine(GetAssetClassInformation());
        }
        
       
    }
}
