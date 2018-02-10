using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min
{
    class Program
    {
        static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            byte colons = byte.Parse(Console.ReadLine());
            byte[,] array = new byte[rows, colons];
            byte[] minCol = new byte[colons];
            for (byte i = 0; i < rows; i++)
            {

                byte[] masiv = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
                for (byte j = 0; j < colons; j++)
                {
                    array[i, j] = masiv[j];

                }
            }
            //obrabotka
            //for (byte i = 0; i < rows; i++)
            //{
            //    for (byte j = 0; j < colons; j++)
            //    {
            //        Console.Write("{0,8}", array[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            
            for (int j = 0; j < colons; j++)
            {
                byte min =array[0, j];
                for (int i = 0; i < rows; i++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
                minCol[j] = min;
            }
            //pechat
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colons; j++)
                {
                    Console.Write("{0,10}", array[i,j ]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < colons; i++)
            {
                Console.Write("{0,10}", minCol[i]);
            }
           

        }
    }
}
