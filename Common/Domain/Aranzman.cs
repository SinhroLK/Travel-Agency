using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Aranzman
    {
        public int AranzmanId { get; set; }
        public string ImeAranzmana { get; set; }
        public double Cena { get; set; }
        public Mesto Mesto { get; set; }
    }
}
