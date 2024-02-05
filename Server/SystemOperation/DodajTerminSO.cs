using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class DodajTerminSO:SystemOperationBase
    {
        private readonly Termin t;
        public object Result { get; set; }

        public DodajTerminSO(Termin p)
        {
            this.t = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Kreiraj(t);
        }
    }
}
