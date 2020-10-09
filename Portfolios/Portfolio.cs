using Bundesbank.Rc1.Übungen.Instruments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Portfolios
{
    public class Portfolio : IPortfolio
    {
        public IList<IPosition> Positions { get; private set; }
        public string Name { get; private set; }

        public Portfolio(string name)
        {
            Name = name;
            Positions = new List<IPosition>();
        }


        //Object config um in einem nächsten Schritt konfigurieren zu können, welche Informationen ausgegeben werden sollen
        public string GetPortfolioStructureInformation(Object config)
        {
            return GetRatingStructureInformation() + GetAssetClassInformation() + GetRatingPerAssetClassInformation() + GetLargestIssuer();

        }


        //Rückgabetyp String, später ggf. mit JSONs o.Ä. überladen
        private string GetRatingStructureInformation()
        {
            //  Aufteilung nach Ratingklassen
            throw new NotImplementedException();
        }
        private string GetAssetClassInformation()
        {
            //Aufteilung in Cash, Credit und Equity Instrumente
            throw new NotImplementedException();
        }
        private string GetRatingPerAssetClassInformation()
        {
            //Aufteilung nach Ratingklassen und Assetklassen
            throw new NotImplementedException();
        }
        private string GetLargestIssuer()
        {
            //Aufteilung nach Issuern
            throw new NotImplementedException();
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
       
    }
}
