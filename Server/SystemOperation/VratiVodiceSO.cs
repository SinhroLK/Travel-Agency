using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class VratiVodiceSO : SystemOperationBase
    {
        private readonly Vodic v;
        public object Result { get; set; }

        public VratiVodiceSO(Vodic p)
        {
            this.v = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.VratiSve(v).Select(x => new Vodic()
            {
                VodicId = ((Vodic)x).VodicId,
                Ime = ((Vodic)x).Ime,
                Plata = ((Vodic)x).Plata,
                BrojTelefona = ((Vodic)x).BrojTelefona,
                DatumRodjenja = ((Vodic)x).DatumRodjenja,
                DatumIstekaUgovora = ((Vodic)x).DatumIstekaUgovora
            }).ToList();
        }
    }
}
