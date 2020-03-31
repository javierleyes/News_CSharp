using System;
using System.Collections.Generic;
using System.Linq;

namespace Yield
{
    public class Program
    {
        public static IEnumerable<int> GetCommonMethod(IList<int> numbers)
        {
            IList<int> multiples = new List<int>();

            foreach (int value in numbers)
            {
                if ((value % 2) == 0)
                {
                    Console.WriteLine($"{value}: calculated by common method");
                    multiples.Add(value);
                }
            }

            return multiples;
        }

        /* REQUIREMENT: THE RETURN TYPE SHOULD BE IENUMERABLE */
        public static IEnumerable<int> GetYieldMethod(IList<int> numbers)
        {
            foreach (int value in numbers)
            {
                if ((value % 2) == 0)
                {
                    Console.WriteLine($"{value}: calculated by yield method");
                    yield return value;
                }
            }
        }

        public static void Main(string[] args)
        {
            IList<int> numbers = Enumerable.Range(1, 10).ToList();

            Console.WriteLine("Common method");

            foreach (int number in GetCommonMethod(numbers).Take(3))
            {
                Console.WriteLine($"{number} is multiples of 2");
            }

            Console.WriteLine();

            Console.WriteLine("Yield method");

            foreach (int number in GetYieldMethod(numbers).Take(3))
            {
                Console.WriteLine($"{number} is multiples of 2");
            }

            Console.WriteLine();

            Console.WriteLine("Only the necessary values were calculated");

            Console.ReadLine();
        }
    }
}

/* output:
 
Common method
2: calculated by common method
4: calculated by common method
6: calculated by common method
8: calculated by common method
10: calculated by common method
2 is multiples of 2
4 is multiples of 2
6 is multiples of 2

Yield method
2: calculated by yield method
2 is multiples of 2
4: calculated by yield method
4 is multiples of 2
6: calculated by yield method
6 is multiples of 2

Only the necessary values ​​were calculated

 */
