using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurence
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started.");

            Console.WriteLine(solution3(new int[] { 1000000000, 1000000, 1000000000, 90000000, 90000000, 77, 77 }));

            Console.ReadKey();
        }


        public static int solution(int[] A)
        {
            foreach (int number in A)
            {                
                if (A.Count(i => i == number) % 2 != 0)
                {
                    return number;
                }                
            }

            return 0;
        }

        public static int solution2(int[] A)
        {
            int safetyLimit = 0;
            
            List<int> numberList = A.OrderBy(i => i).ToList<int>();

            // Loop until the unique number of values is 1.
            while (numberList.Distinct().Count() > 1)
            {
                int number = numberList.First();

                // Check for even occurences
                if (A.Count(i => i == number) % 2 == 0)
                {
                    // Remove this number since it is even.
                    numberList.RemoveAll(i => i == number);                    
                }
                else
                {
                    // We found the odd number occurance. So we can finish.
                    return number;
                }

                // Safety limit test.
                if (safetyLimit > 999999)
                {
                    return 0;
                }
                else
                {
                    safetyLimit++;
                }
            }

            // There should be only one number left.
            return numberList.First();
        }

        public static int solution3(int[] A)
        {
            // Sort and check adjacent number.
            Array.Sort(A);

            //var numberList = A.Where(i => i <= 1000000).OrderBy(i => i).ToArray();

            for (int i = 0; i < A.Length - 1; i += 2)
            {
                if (A[i] != A[i + 1])
                {
                    return A[i];
                }
            }

            return A.Last();
        }


        public static int solution4(int[] A)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            foreach (int value in A)
            {
                if (pairs.ContainsKey(value))
                {
                    // increment key. The odd item may have other pairs.
                    pairs[value] += 1;
                }
                else
                {
                    // First occurence found.
                    pairs[value] = 1;
                }
            }

            return pairs.Where(x => x.Value % 2 != 0).Select(x => x.Key).FirstOrDefault();
        }
    }
}
