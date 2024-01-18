using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    [Serializable]
    public class Response
    {
        public object Odgovor { get; set; }
        public Operation Operacija { get; set; }
        public Exception Exception { get; set; }
    }
}
