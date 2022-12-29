using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional4Tasks
{
    public static class Tasks
    {
        public static int Task1(int[,] array)
        {
            int product = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        product *= array[i, j];
                    }

                }
            }

            return product;
        }

        public static double Task2(int[,] array)
        {
            double maxValue = 0;
            double mean = 0;
            double[] meanarray = new double[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    mean += array[i, j];
                    
                }
                meanarray[i] = mean / array.GetLength(1);
                mean = 0;
            }
                maxValue = meanarray.Max();

                return maxValue;
        }

        public static int[] Task3(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int sum = 0;
            int[] sumarray = new int[columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += array[j, i];
                }
                
                sumarray[i] = sum;
                sum = 0;   
            }
            return sumarray;
        }
    }
}
