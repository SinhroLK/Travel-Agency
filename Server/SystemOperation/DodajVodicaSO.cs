using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{

    public class DodajVodicaSO : SystemOperationBase
    {
        private readonly Vodic v;
        public object Result
        {
            get; set;
        }
        public DodajVodicaSO(Vodic p)
        {
            this.v = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Kreiraj(v);
        }
    }
}
