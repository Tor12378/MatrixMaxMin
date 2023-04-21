using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class MaxMin
    {
        public  int[,] m;
        public MaxMin(Matrix mtr) 
        { 
            m = mtr.matr;
        }
        public  List<int> ar=new List<int>();

        public int Max()
        {
            for (var i = 0; i <m.GetLength(1); i++)
            {
                Thread myThread = new(Print);
                myThread.Start(i);
            }
            return ar.Max();
        }
        void Print(object? obj)
        {
            
                int min = int.MaxValue;
                for (int i = 0; i < m.GetLength(1); i++)
                {
                    if (m[(int)obj, i] < min)
                    {
                        min = m[(int)obj, i];
                    }
                }
                ar.Add(min);
            
        }

    }
}
