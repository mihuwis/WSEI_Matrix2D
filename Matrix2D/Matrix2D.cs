using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2D
{
    internal class Matrix2D : IEquatable<Matrix2D>
    {
        private int _a;
        private int _b;
        private int _c;
        private int _d;

        public int A { get; }
        public int B { get; }
        public int C { get; }
        public int D { get; }
        public Matrix2D()
        {
            this._a = 1;
            this._b = 0;
            this._c = 0;
            this._d = 1;
        }

        public Matrix2D(int a, int b, int c, int d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public static readonly Matrix2D Id = new Matrix2D();
        public static readonly Matrix2D Zero = new Matrix2D(0, 0, 0, 0);

        public override string ToString()
        {
            return $"[[{_a}, {_b}][{_c}, {_d}]";
        }

        // Equals from IEquatable interface
        public bool Equals(Matrix2D? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true; // If Other and This are references to this same object
            return A == other.A && B == other.B && C == other.C && D == other.D ;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Matrix2D) 
                return Equals((Matrix2D)obj);
            else
            return false;
        }

        public static bool Equals(Matrix2D a, Matrix2D b)
        {
            if ((a is null) &&  (b is null)) return true;
            if(a is null) return false;
            return a.Equals(b);
        }

        public override int GetHashCode() => (_a, _b, _c, _d).GetHashCode();

        public static bool operator ==(Matrix2D m1 , Matrix2D m2) => Equals(m1, m2);
        public static bool operator !=(Matrix2D m1 , Matrix2D m2) => !(m1 == m2);

    }
}
