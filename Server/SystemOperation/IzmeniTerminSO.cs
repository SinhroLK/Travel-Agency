using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class IzmeniTerminSO:SystemOperationBase
    {
        private readonly Termin t;
        public object Result
        {
            get; set;
        }
        public IzmeniTerminSO(Termin p)
        {
            this.t = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Izmeni(t);
        }
    }
}
