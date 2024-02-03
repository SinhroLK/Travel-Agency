using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiAranzmaneSO:SystemOperationBase
    {
        private readonly Aranzman a;
        public object Result { get; set; }

        public VratiAranzmaneSO(Aranzman p)
        {
            this.a = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.VratiSve(a).Select(x => new Aranzman()
            {
                AranzmanId = ((Aranzman)x).AranzmanId,
                ImeAranzmana = ((Aranzman)x).ImeAranzmana,
                Cena = ((Aranzman)x).Cena,
                Opis = ((Aranzman)x).Opis,
                Mesto = ((Aranzman)x).Mesto
            }).ToList();
        }
    }
}
