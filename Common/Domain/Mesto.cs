using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Mesto
    {
        public int MestoId { get; set; }
        public string NazivMesta { get; set; }
        public string Valuta { get; set; }
        public int BrojStanovnika { get; set; }
    }
}
