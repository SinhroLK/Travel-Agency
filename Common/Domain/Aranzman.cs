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

        public int id => AranzmanId;

        public string idColumnName => throw new NotImplementedException();

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Aranzman ar = new Aranzman();
                ar.AranzmanId = (int)reader["aranzman_id"];
                ar.ImeAranzmana = (string)reader["ime_aranzmana"];
                ar.Cena = (double)reader["cena"];
                ar.Opis = (string)reader["opis"];
                Mesto me = new Mesto();
                me.MestoId = (int)reader["mesto_id"];
                ar.Mesto = me;
                lista.Add(ar);
            }
            return lista;
        }
    }
}
