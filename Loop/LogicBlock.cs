using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class LogicBlock
    {
        public bool north { get; set; }
        public bool south { get; set; }
        public bool east { get; set; }
        public bool west { get; set; }
        public bool type { get; set; }
        public LogicBlock(bool n, bool s, bool e, bool w)
        {
            north = n;
            south = s;
            east = e;
            west = w;
        }
    }
}
