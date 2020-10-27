using Bundesbank.Rc1.Übungen.Portfolios;
using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorUndDesignübung.Visitors
{
    public interface IPositionVisitor
    {
        public void Initiate();
        public void Visit(IPosition position);
        public void Finish();
    }
}
