using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class ProlaznoMesto : IEntity
    {
        public Aranzman Aranzman { get; set; }
        public Mesto Mesto { get; set; }
        public int Satnica { get; set; }
        public bool Prenociste { get; set; }

        public string TableName => "ProlaznoMesto";
        public string Values => $"'{Aranzman.AranzmanId}', '{Mesto.MestoId}', '{Satnica}', '{(Prenociste ? 1 : 0)}'";

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                ProlaznoMesto pm = new ProlaznoMesto();
                Aranzman ar = new Aranzman();
                Mesto me = new Mesto();
                ar.AranzmanId = (int)reader["aranzman_id"];
                pm.Aranzman = ar;
                me.MestoId = (int)reader["mesto_id"];
                pm.Mesto = me;
                pm.Satnica = (int)reader["satnica"];
                pm.Prenociste = (bool)reader["prenociste"];
                lista.Add(pm);
            }
            return lista;
        }
    }
}
