using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp12
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var n = 5;
            var m = new Matrix(n);
            Console.WriteLine(m);
            var t = new MaxMin(m);
            Console.WriteLine(t.Max());
        }
    }
}