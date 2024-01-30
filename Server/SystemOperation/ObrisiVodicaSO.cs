using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class ObrisiVodicaSO : SystemOperationBase
    {
        private readonly Vodic v;
        public object Result
        {
            get; set;
        }
        public ObrisiVodicaSO(Vodic p)
        {
            this.v = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Obrisi(v);
        }
    }
}
