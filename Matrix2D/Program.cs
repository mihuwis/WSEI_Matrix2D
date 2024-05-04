namespace Matrix2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELOCOME to Matrix!!!");
            Matrix2D matrix2D = new Matrix2D();
            Console.WriteLine(matrix2D.ToString());
            Console.WriteLine(Matrix2D.Zero.ToString());
        }
    }
}
