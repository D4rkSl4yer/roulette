using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roulette
{
    internal class field
    {
        public char col;
        public int num;

        public field(string full)
        {
            this.col = full[0];
            this.num = int.Parse(full.Remove(1,2));
        }
    }
}
