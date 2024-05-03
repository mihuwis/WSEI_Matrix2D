using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2D
{
    internal class Matrix2D
    {
        private int A { get; }
        private int B { get; }
        private int C { get; }
        private int D { get; }
        public Matrix2D()
        {
            this.A = 1;
            this.B = 0;
            this.C = 1;
            this.D = 0;
        }

        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

    }
}
