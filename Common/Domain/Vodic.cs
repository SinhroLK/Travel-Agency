using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Vodic
    {
        public int VodicId { get; set; }
        public string Ime { get; set; }
        public DateTime DatumRodjenja{ get; set; }
        public double Plata { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumIstekaUgovora { get; set; }

    }
}
