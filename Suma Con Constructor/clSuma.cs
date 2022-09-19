using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_Con_Constructor
{
    internal class clSuma
    {
        int v1, v2;

        public clSuma(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int suma()
        {
            return v1+ v2;
        }
    }
}
