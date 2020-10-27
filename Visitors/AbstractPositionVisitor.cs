using Bundesbank.Rc1.Übungen.Portfolios;
using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorUndDesignübung.Visitors
{
   public abstract class AbstractPositionVisitor : IPositionVisitor
    {
        public virtual void Finish()
        {
          
        }

        public virtual void Initiate()
        {
            
        }

        public abstract void Visit(IPosition position);
        
    }
}
