using Bundesbank.Rc1.Übungen.Portfolios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VisitorUndDesignübung.Portfolios.PortfolioInformationObjects
{
    public class PortfolioAssetStructureInformation : IPortfolioInformationObject
    {
        private IDictionary<string, decimal> assetStructure;
        string IPortfolioInformationObject.InformationTitle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public PortfolioAssetStructureInformation(IDictionary<string,decimal> assetStructureInfo)
        {
            assetStructure = assetStructureInfo;
            if (!assetStructure.ContainsKey("Total")) assetStructure.Add("Total", 0);
        }


        public void PrintToConsole()
        {
            throw new NotImplementedException();
        }

        public void PutToDatabase()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string result;
            result = "Die Assetstruktur des Portfolios ist: \n";
            foreach (var assetclass in assetStructure)
            {
                result = result + $"Ratingklasse {assetclass.Key}: {assetclass.Value} ({assetclass.Value / assetStructure["Total"]})" + Environment.NewLine;
            }
            return result;

        }
    }
}
