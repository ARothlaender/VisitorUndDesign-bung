using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Instruments
{
    public interface IInstrument
    {
        //Instrumente können abhängig davon, ob ein Marktpreis existiert, ihren Preis zurückgeben 
        //So können bspw. Berechnungslogiken bei Floatern eingebaut werden, häufig wird die Methode aber als
        //Return price implementiert.
        public decimal Evaluate();

        public string Issuer { get;}
        public string ISIN { get;}
        public string Currency { get; }
        public string Rating { get; set; }

    }
}
