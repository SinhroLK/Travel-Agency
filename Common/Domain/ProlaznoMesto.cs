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

        public string TableName => "ProlaznoMesto";
        public string Values => $"'{Aranzman.AranzmanId}', '{Mesto.MestoId}'";

        public int id { get => Aranzman.AranzmanId; set => Aranzman.AranzmanId = value; } 

        public string idColumnName => "aranzman_id";

        public string zaJoin => "join Aranzman on(Aranzman.aranzman_id = ProlaznoMesto.aranzman_id) join Mesto on(Mesto.mesto_id = ProlaznoMesto.mesto_id";

        public string zaSet => $"mesto_id = {Mesto.MestoId}";

        public override string ToString()
        {
            return $"{Aranzman} {Mesto}";
        }

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                ProlaznoMesto pm = new ProlaznoMesto();
                Aranzman ar = new Aranzman();
                ar.AranzmanId = (int)reader["aranzman_id"];
                ar.ImeAranzmana = (string)reader["ime_aranzmana"];
                ar.Cena = (int)reader["cena"];
                ar.Opis = (string)reader["opis"];
                Mesto me = new Mesto();
                me.MestoId = (int)reader["mesto_id"];
                me.NazivMesta = (string)reader["naziv"];
                ar.Mesto = me;
                lista.Add(pm);
            }
            return lista;
        }
    }
}
