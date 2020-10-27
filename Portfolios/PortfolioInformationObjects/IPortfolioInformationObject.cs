using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Portfolios
{
    public interface IPortfolioInformationObject
    {

        //vlt. hier eine Factory einabuen bzw. Factory Methoden, damit man die Abhängigkeiten in den Visitors reduziert
        public string InformationTitle { get; protected set; }


        public void PrintToConsole();
        public void PutToDatabase();
        
        // public 'JSONObject' OutputAsJSON();

        // public void GetGraphicRepresentation();

    }
}
