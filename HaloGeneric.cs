using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302213016
{
    internal class HaloGeneric
    {
        public void SapaUser<t>(t nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }
}
