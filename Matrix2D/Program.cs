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
            Console.WriteLine("----------------------------------------------------------------");
            Matrix2D matrix1001 = new Matrix2D();
            Console.WriteLine($"MAatrix1001: {matrix1001}");

            Matrix2D matrix5555 = new Matrix2D(5, 5, 5, 5);
            Console.WriteLine($"matric5555: {matrix5555}");

            Matrix2D matrix1234 = new Matrix2D(1, 2, 3, 4);
            Console.WriteLine($"matric1234: {matrix1234}");


            Matrix2D sum01 = matrix1001 + matrix5555;
            
            Console.WriteLine($"Suma: {sum01}");

            Matrix2D sum02 = matrix5555 + matrix1234;
            Console.WriteLine($"Suma: {sum02}");
            Matrix2D multi01 = matrix1234 * matrix1234;
            Console.WriteLine($"Multi : {multi01}");
            Matrix2D multiK2 = matrix1234 * 2;
            Console.WriteLine($"Multi x 2 : {multiK2}");

        }
    }
}
