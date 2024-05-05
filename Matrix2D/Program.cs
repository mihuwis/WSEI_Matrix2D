namespace Matrix2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELOCOME to Matrix!!!");
            Matrix2D matrix2D = new Matrix2D();
            Matrix2D matrix2D1 = new Matrix2D();
            Console.WriteLine(matrix2D.ToString());
            Console.WriteLine(Matrix2D.Zero.ToString());



            Console.WriteLine("dwa jedykwe równe = " + (matrix2D == matrix2D1));
            Console.WriteLine("pola A == = " + (matrix2D.A == matrix2D1.A));
            Console.WriteLine("dwa jedykwe equal = " + (matrix2D.Equals(matrix2D1)));
            Console.WriteLine("pola A równe equal = " + (matrix2D.A.Equals(matrix2D1.A)));

        }
    }
}
