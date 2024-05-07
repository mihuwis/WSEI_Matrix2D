using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2D.Tests
{
    [TestClass()]
    public class Matrix2DTests
    {
        [TestMethod()]
        public void Matrix2DTest()
        {
            var m = new Matrix2D(1, 2, 3, 4);

            var a = m.A;
            var b = m.B;
            var c = m.C;
            var d = m.D;

            Assert.AreEqual(1, a);
            Assert.AreEqual(2, b);
            Assert.AreEqual(3, c);
            Assert.AreEqual(4, d);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            Assert.AreEqual("[[1, 2][3, 4]]", m.ToString());
        }

        [TestMethod()]
        public void Equals_ReturnsTrueForSameReference()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            Assert.IsTrue(m.Equals(m));
        }

        [TestMethod()]
        public void Equals_ReturnsFalseForNull()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            Assert.IsFalse(m.Equals(null));
        }

        [TestMethod()]
        public void Equals_ReturnsTrueForEqualMatrices()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(1, 2, 3, 4);
            Assert.IsTrue(m1.Equals(m2));
        }

        public void Equals_ReturnsFalseForDifferentMatrices()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(6, 9, 3, 4);
            Assert.IsFalse(m1.Equals(m2));
        }

        [TestMethod()]
        public void GetHashCode_ReturnsSameValueForEqualMatrices()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(1, 2, 3, 4);
            Assert.AreEqual(m1.GetHashCode(), m2.GetHashCode());
        }

        [TestMethod()]
        public void GetHashCode_ReturnsDifferentValueForDifferentMatrices()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(1, 4, 0, 9);
            Assert.AreNotEqual(m1.GetHashCode(), m2.GetHashCode());
        }

        [TestMethod()]
        public void Transpose_Test()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(1, 3, 2, 4);
            Assert.AreEqual(m2, m1.Transpose(m1));
        }
    }
}