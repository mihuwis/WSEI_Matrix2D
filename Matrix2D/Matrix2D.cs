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
            this.C = 0;
            this.D = 1;
        }

        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public static readonly Matrix2D Id = new Matrix2D();
        public static readonly Matrix2D Zero = new Matrix2D(0, 0, 0, 0);

        public override string ToString()
        {
            return $"[[{A}, {B}][{C}, {D}]";
        }

    }
}
