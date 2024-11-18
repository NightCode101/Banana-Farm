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

namespace Banana_Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double banana;

            Console.Write("Enter Banana Size Between 2 - 10: ");
            banana = Convert.ToDouble(Console.ReadLine());

            if (banana > 2 && banana <= 4)
            {   
                Console.WriteLine("Native Banana");
            }
            else if (banana > 2 && banana <= 4 )
            {
                Console.WriteLine("Manila");
            }
            else if (banana > 4 && banana <= 5.5)
            { 
                Console.WriteLine("Damilig");
            }
            else if (banana > 5.5 && banana <= 7)
            {
                Console.WriteLine("Barangan");
            }
            else if (banana >= 7 && banana <= 8)
            {
                Console.WriteLine("Lakatan");
            }
            else if (banana > 8 && banana <= 10)
            {
                Console.WriteLine("Davao");
            }
            else if (banana > 10)
            {
                Console.WriteLine("Jumbo Banana");
            }
            else 
            {
                Console.WriteLine("Try Again!");
            }

        }
    }
}
