using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class IzmeniAranzmanSO:SystemOperationBase
    {
        private readonly Aranzman a;
        public IEntity Result
        {
            get; set;
        }
        public IzmeniAranzmanSO(Aranzman p)
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
            foreach (ProlaznoMesto p in a.prolaznaMesta)
            {
                broker.Kreiraj(p);
            }
            Result = broker.Izmeni(a);
        }
    }
}
