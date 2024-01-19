using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Sadrzaj
    {
        public int RedniBroj { get; set; }
        public Mesto Mesto { get; set; }
        public string Opis { get; set; }
    }
}
