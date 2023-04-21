using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Matrix
    {
        public int[,] matr;
        public int size;


        public Matrix(int n)
        {
            size = n;
            matr = new int[size, size];
            Random r = new Random();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matr[i, j] = r.Next(0, 1000);
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    sb.Append($" {matr[i, j]}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
