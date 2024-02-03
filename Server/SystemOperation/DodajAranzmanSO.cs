using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class DodajAranzmanSO : SystemOperationBase
    {
        private readonly Aranzman a;
        public object Result
        {
            get; set;
        }
        public DodajAranzmanSO(Aranzman p)
        {
            this.a = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Kreiraj(a);
        }
    }
}
