using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiTermineSO:SystemOperationBase
    {
        private readonly Termin t;
        public object Result { get; set; }

        public VratiTermineSO(Termin p)
        {
            this.t = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.VratiSve(t).Select(x => new Termin()
            {
                RedniBroj = ((Termin)x).RedniBroj,
                Aranzman = ((Termin)x).Aranzman,
                Vodic = ((Termin)x).Vodic,
                DatumOd = ((Termin)x).DatumOd,
                DatumDo = ((Termin)x).DatumDo
            }).ToList();
        }
    }
}
