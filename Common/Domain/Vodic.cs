using System;
using System.Collections.Generic;
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
    }
}
