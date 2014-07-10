using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Offset
    {
        public String Search { get; set; }
        public String Value { get; set; }

        public Offset(string s, string v)
        {
            Search = s;
            Value = v;
        }
    }
}
