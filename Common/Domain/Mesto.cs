using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public string Values => $"'{NazivMesta}', '{Valuta}', {BrojStanovnika}";

        public int id => MestoId;

        public string idColumnName => "mesto_id";

        public string zaJoin => "";

        public override string ToString()
        {
            return NazivMesta;
        }

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Mesto mesto = new Mesto()
                {
                    MestoId = (int)reader["mesto_id"],
                    NazivMesta = (string)reader["naziv"],
                    Valuta = (string)reader["valuta"],
                    BrojStanovnika = (int)reader["broj_stanovnika"]
                };
                lista.Add(mesto);

            }
            return lista;

        }
    }
}
