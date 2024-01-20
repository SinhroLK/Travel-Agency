using System;
using System.Collections.Generic;
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
    }
}
