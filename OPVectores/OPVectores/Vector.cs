using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPVectores
{
    class Vector
    {
        public int[] A { get; set; }
        public int[] B { get; set; }

        public Vector(int[] A, int[] B)
        {
            this.A = A;
            this.B = B;
        }
       
    }
}

