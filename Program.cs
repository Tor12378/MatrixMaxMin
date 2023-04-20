using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp12
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var n = 5;
            var m = MadeMatrix.Made(n);
            for(int i = 0; i < n; i++)
            {
                for(int j=0;j < n; j++)
                {
                    Console.Write($"{ m[i, j]} ");
                }
                Console.WriteLine();
            }
            var t = new maxmin( m);
            Console.WriteLine(t.Max());
        }
    }
}