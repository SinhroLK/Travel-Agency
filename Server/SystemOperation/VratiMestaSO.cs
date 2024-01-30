using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class VratiMestaSO : SystemOperationBase
    {
        private readonly Mesto m;
        public object Result { get; set; }

        public VratiMestaSO(Mesto p)
        {
            this.m = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.VratiSve(m).Select(x => new Mesto()
            {
                MestoId = ((Mesto)x).MestoId,
                NazivMesta = ((Mesto)x).NazivMesta,
                Valuta = ((Mesto)x).Valuta,
                BrojStanovnika = ((Mesto)x).BrojStanovnika

            }).ToList();
        }
    }
}
