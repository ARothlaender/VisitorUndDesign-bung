using Bundesbank.Rc1.Übungen.Portfolios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace VisitorUndDesignübung.Portfolios.PortfolioInformationObjects
{
    public class PortfolioRatingInformation : IPortfolioInformationObject
    {
        private IDictionary<string, decimal> RatingStructure;

        public PortfolioRatingInformation(string RatingStructure)
        {
        }

        public PortfolioRatingInformation(IDictionary<string, decimal> inputData)
        {
            
            this.RatingStructure = inputData;
            if (!RatingStructure.ContainsKey("Total")) RatingStructure.Add("Total", 0);
        }

       string IPortfolioInformationObject.InformationTitle {get; set;}

        public void PrintToConsole()
        {
            Console.WriteLine(this);
        }

        public void PutToDatabase()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string result;
            result = "Die Ratingstruktur des Portfolios ist: \n";
            foreach(var ratingclass in RatingStructure)
            {
                result = result + $"Ratingklasse {ratingclass.Key}: {ratingclass.Value} ({ratingclass.Value / RatingStructure["Total"]})" + Environment.NewLine;
            }
            return result;

        }

    }
}
