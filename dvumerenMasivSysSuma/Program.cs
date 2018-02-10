using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvumerenMasivSysSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            byte colons = byte.Parse(Console.ReadLine());
            byte[,] array = new byte[rows, colons];
           
            for (byte i = 0; i < rows; i++)
            {
                for (byte j = 0; j < colons; j++)
                {
                    array[i, j] = byte.Parse(Console.ReadLine());
                    
                }
            }
            for (byte i = 0; i < rows ; i++)
            {
                float sum = 0f;
                for (byte j = 0; j < colons ; j++)
                {
                    sum += array[i, j];
                    
                    Console.Write("{0,8}", array[i, j]);

                }
                Console.WriteLine($"{sum/colons,8}");
            }
        }
    }
}
