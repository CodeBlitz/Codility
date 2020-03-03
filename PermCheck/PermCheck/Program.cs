using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 4, 1, 3, 2 }));
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);

            // Permutation is a seq containing 1 to N, only once.
            if (A[0] == 1)
            {
                if (A.Length == 1)
                {
                    return 1;
                }
                else
                {
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        if (A[i] + 1 != A[i + 1])
                        {
                            return 0;
                        }
                    }

                    return 1;
                }
            }
            else
            {
                // Sequence does not start with 1.
                return 0;
            }
        }
    }
}
