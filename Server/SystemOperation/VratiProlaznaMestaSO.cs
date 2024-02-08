using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiProlaznaMestaSO:SystemOperationBase
    {
        private readonly ProlaznoMesto m;
        public object Result { get; set; }

        public VratiProlaznaMestaSO(ProlaznoMesto p)
        {
            this.m = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.VratiSve(m).Select(x => new ProlaznoMesto()
            {
                Aranzman = ((ProlaznoMesto)x).Aranzman,
                Mesto = ((ProlaznoMesto)x).Mesto
            }).ToList();
        }
    }
}
