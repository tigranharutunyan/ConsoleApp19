using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 50; i <= 70; i++)
            {
                int number;
                if (i % 2 == 0)
                {
                    while (i % 2 == 0)
                    {
                        number = i / 2;
                        i = number;
                        if (number == 1)
                        {
                            Console.WriteLine(number);
                            break;
                        }                       
                    }
                }
                else
                {
                    i = i * 3 + 1;
                    while (i % 2 == 0)
                    {
                        number = i / 2;
                        i = number;
                        if (number == 1)
                        {
                            Console.WriteLine(number);
                            break;
                        }                      
                    }
                }                             
            }
        }
                   
     }
}
