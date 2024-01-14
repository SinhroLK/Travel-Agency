using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class ProlaznoMesto
    {
        public Aranzman Aranzman { get; set; }
        public Mesto Mesto { get; set; }
        public int Satnica { get; set; }
        public bool Prenociste { get; set; }
    }
}
