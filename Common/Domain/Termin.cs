using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Termin : IEntity
    {
        public int RedniBroj { get; set; }
        public Aranzman Aranzman { get; set; }
        public Vodic Vodic { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }

        public string TableName => "Termin";
        public string Values => $"'{Aranzman.AranzmanId}', '{Vodic.VodicId}', '{DatumOd.ToString("yyyyMMdd")}', '{DatumDo.ToString("yyyyMMdd")}'";

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Aranzman ar = new Aranzman();
                Vodic vo = new Vodic();
                Termin termin = new Termin();
                termin.RedniBroj = (int)reader["termin_id"];
                ar.AranzmanId = (int)reader["aranzman_id"];
                vo.VodicId = (int)reader["vodic_id"];
                termin.Aranzman = ar;
                termin.Vodic = vo;
                termin.DatumOd = (DateTime)reader["datum_od"];
                termin.DatumDo = (DateTime)reader["datum_do"];
                lista.Add(termin);

            }
            return lista;
        }
    }
}
