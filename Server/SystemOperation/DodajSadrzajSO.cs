using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class DodajSadrzajSO:SystemOperationBase
    {
        private readonly Sadrzaj s;
        public object Result { get; set; }

        public DodajSadrzajSO(Sadrzaj p)
        {
            this.s = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Kreiraj(s);
        }
    }
}
