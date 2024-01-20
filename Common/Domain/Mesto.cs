using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Mesto : IEntity
    {
        public int MestoId { get; set; }
        public string NazivMesta { get; set; }
        public string Valuta { get; set; }
        public int BrojStanovnika { get; set; }

        public string TableName => "Mesto";
        public string Values => $"'{NazivMesta}', '{Valuta}', '{BrojStanovnika}'";
    }
}
