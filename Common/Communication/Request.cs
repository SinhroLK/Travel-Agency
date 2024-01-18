using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class Request
    {
        public object Argument { get; set; }
        public Operation Operation { get; set; }
    }
}
