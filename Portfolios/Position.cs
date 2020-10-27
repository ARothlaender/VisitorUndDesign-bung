using Bundesbank.Rc1.Übungen.Instruments;
using System;
using System.Collections.Generic;
using System.Text;
using VisitorUndDesignübung.Visitors;

namespace Bundesbank.Rc1.Übungen.Portfolios
{
    public class Position : IPosition
    {
        private decimal marketValue;
        private readonly IInstrument instrument;

        IInstrument IPosition.Instrument => this.instrument;
        public decimal NominalAmount { get; set; }
        public decimal MarketValue { get => NominalAmount * instrument.Evaluate();
                                     set => marketValue = value; }

        

        public Position(IInstrument instrument,decimal nominalAmount)
        {
            this.instrument = instrument;
            this.NominalAmount = nominalAmount;
        }
        public override string ToString()
        {
            return $"Diese Position enthält ein Instrument des Issuers {this.instrument.Issuer} mit einem Marktwert von {MarketValue}";
        }

        public void accept(IPositionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
