using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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

        public int id => RedniBroj;

        public string idColumnName => "termin_id";

        public string zaJoin => "join Aranzman on (Termin.aranzman_id=Aranzman.aranzman_id) join Vodic on (Termin.vodic_id = vodic.vodic_id) join Mesto on (Aranzman.mesto_id = Mesto.mesto_id)";

        public string zaSet => throw new NotImplementedException();

        public string Mesto => Aranzman.Mesto.ToString();

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Aranzman ar = new Aranzman();
                Vodic vo = new Vodic();
                Termin termin = new Termin();
                termin.RedniBroj = (int)reader["termin_id"];
                vo.VodicId = (int)reader["vodic_id"];
                ar.AranzmanId = (int)reader["aranzman_id"];
                ar.ImeAranzmana = (string)reader["ime_aranzmana"];
                ar.Cena = (int)reader["cena"];
                ar.Opis = (string)reader["opis"];
                Mesto me = new Mesto();
                me.MestoId = (int)reader["mesto_id"];
                me.NazivMesta = (string)reader["naziv"];
                ar.Mesto = me;
                vo.VodicId = (int)reader["vodic_id"];
                vo.Ime = (string)reader["ime"];
                vo.Plata = (int)reader["plata"];
                vo.BrojTelefona = (string)reader["broj_telefona"];
                vo.DatumRodjenja = (DateTime)reader["datum_rodjenja"];
                vo.DatumIstekaUgovora = (DateTime)reader["datum_isteka_ugovora"];
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
