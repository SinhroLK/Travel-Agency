using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Aranzman : IEntity
    {
        public int AranzmanId { get; set; }
        public string ImeAranzmana { get; set; }
        public double Cena { get; set; }
        public string Opis { get; set; }
        public Mesto Mesto { get; set; }

        public string TableName => "Aranzman";

        public string Values => $"'{ImeAranzmana}', '{Cena}', '{Opis}', '{Mesto.MestoId}'";

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
