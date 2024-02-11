using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class ObrisiAranzmanSO:SystemOperationBase
    {
        private readonly Aranzman a;
        public IEntity Result
        {
            get; set;
        }
        public ObrisiAranzmanSO(Aranzman p)
        {
            this.a = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            foreach (ProlaznoMesto p in a.prolaznaMesta)
            {
                broker.Obrisi(p);
                break;
            }
            Result = broker.Obrisi(a);
        }
    }
}
