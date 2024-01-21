using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class DodajMestoSO : SystemOperationBase
    {
        private readonly Mesto m;
        public object Result { get; set; }

        public DodajMestoSO(Mesto p)
        {
            this.m = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.KreirajMesto(m);
        }
    }
}
