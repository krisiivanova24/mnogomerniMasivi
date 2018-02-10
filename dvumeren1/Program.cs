using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvumeren1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte row = byte.Parse(Console.ReadLine());//redove
            byte colons = byte.Parse(Console.ReadLine());//koloni
            byte[,] arr2 = new byte[row, colons];

            for (int i = 0; i < row; i++)//i obikalq red po red
            {
                for (int j = 0; j < colons; j++)//j minava po vsichki elementi na 1 red
                {
                    arr2[i, j] = byte.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)//i obikalq red po red
            {
                for (int j = 0; j < colons; j++)//j minava po vsichki elementi na 1 red
                {
                    Console.Write("{0} ",arr2[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
