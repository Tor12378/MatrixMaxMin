using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class MadeMatrix
    {
        public static int[,] Made(int size)
        {
            var matrix=new int[size,size];
            Random r = new Random();
            for(int i = 0; i < size; i++)
            {
                for(int j=0;j < size; j++)
                {
                    matrix[i, j] = r.Next(0,1000);
                }
            }
            return matrix;
        }
    }
}
