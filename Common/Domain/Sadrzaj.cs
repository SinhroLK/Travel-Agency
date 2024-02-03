using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Sadrzaj : IEntity
    {
        public int RedniBroj { get; set; }
        public Mesto Mesto { get; set; }
        public string Opis { get; set; }

        public string TableName => "Sadrzaj";
        public string Values => $"{Mesto.MestoId}, '{Opis}'";

        public int id => RedniBroj;

        public string idColumnName => "redni_broj";

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Sadrzaj sa = new Sadrzaj();
                Mesto me = new Mesto();
                sa.RedniBroj = (int)reader["redni_broj"];
                me.MestoId = (int)reader["mesto_id"];
                sa.Mesto = me;
                sa.Opis = (string)reader["opis"];
                lista.Add(sa);
            }
            return lista;
        }
    }
}
