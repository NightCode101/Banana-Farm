/*
Create a program that will ask the user to enter the size of their desired banana.

| Varitey:              | Size:                                             |
| Native Banana         | less than 2 inches                                |
| Manila                | more than 2 inches to 4 inches                    |
| Damilig               | more than 4 inches to 5.5 inches                  |
| Barangan              | more than 5.5 inches to less less than 7 inches   |
| Lakatan               | 7 inches to 8 inches                              |
| Davao                 | more than 8 inches to 10 inches                   |
| Jumbo Banana          | more than 10 inches                               |

 */

using System;
using System.Linq;
using System.Collections.Generic;

namespace bananafarm_sheesh
{
    class Program
    {
        static void Main()
        {
            double banana_size;

            Console.Write("What size of banana do you want?\nChoose from 1-10 Inches:");
            banana_size = Convert.ToDouble(Console.ReadLine());

            Console.Write("Your banana variety is: ");

            if (banana_size <= 2 && banana_size != 0)
            {
                Console.Write("Native banana");
            }
            else if (banana_size > 2 && banana_size <= 4)
            {
                Console.Write("Manila");
            }
            else if (banana_size > 4 && banana_size <= 5.5)
            {
                Console.Write("Damilig");
            }
            else if (banana_size >= 5.5 && banana_size <= 7)
            
                Console.Write("Barangan");
            }
            else if (banana_size >= 7 && banana_size <= 8)
            {
                Console.Write("Lakatan");
            }
            else if (banana_size >= 8 && banana_size <= 10)
            {
                Console.Write("Davao");
            }
            else if (banana_size > 10)
            {
                Console.Write("Jumbo banana");
            }
            else
            {
                Console.Write("Invalid input");
            }
            Console.ReadLine();

        }
    }
}