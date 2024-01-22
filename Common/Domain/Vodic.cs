using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Vodic : IEntity
    {
        public int VodicId { get; set; }
        public string Ime { get; set; }
        public DateTime DatumRodjenja{ get; set; }
        public double Plata { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumIstekaUgovora { get; set; }
        public string TableName => "Vodic";
        public string Values => $"'{Ime}', '{DatumRodjenja.ToString("yyyyMMdd")}', '{Plata}', '{BrojTelefona}', '{DatumIstekaUgovora.ToString("yyyyMMdd")}'";

        public List<IEntity> VratiReaderListu(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Vodic vodic = new Vodic()
                {
                    VodicId = (int)reader["vodic_id"],
                    Ime = (string)reader["ime"],
                    Plata = (int)reader["plata"],
                    BrojTelefona = (string)reader["broj_telefona"],
                    DatumRodjenja = (DateTime)reader["datum_rodjenja"],
                    DatumIstekaUgovora = (DateTime)reader["datum_isteka_ugovora"]
                };
                lista.Add(vodic);

            }
            return lista;
        }
    }
}
