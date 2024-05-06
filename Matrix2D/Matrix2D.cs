using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2D
{
    internal class Matrix2D : IEquatable<Matrix2D>
    {
        public int A { get; init; }
        public int B { get; init; }
        public int C { get; init; }
        public int D {  get; init; }

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
        public static readonly Matrix2D Zero = new Matrix2D() { A = 0, B = 0, C = 0, D = 0};

        public override string ToString()
        {
            return $"[[{A}, {B}][{C}, {D}]]";
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

        public override int GetHashCode() => (A, B, C, D).GetHashCode();

        public static bool operator ==(Matrix2D m1 , Matrix2D m2) => Equals(m1, m2);
        public static bool operator !=(Matrix2D m1 , Matrix2D m2) => !(m1 == m2);

        public static Matrix2D operator +(Matrix2D m1, Matrix2D m2)
        {
            return new Matrix2D((m1.A + m2.A), (m1.B + m2.B), (m1.C + m2.C), (m1.D + m2.D));
        }

        public static Matrix2D operator -(Matrix2D m1, Matrix2D m2)
        {
            return new Matrix2D((m1.A - m2.A), (m1.B - m2.B), (m1.C - m2.C), (m1.D - m2.D));
        }

    }
}
