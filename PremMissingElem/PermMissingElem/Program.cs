using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(solution(new int[] { 2, 3, 1, 5 }));
            Console.WriteLine(solution(new int[] { 1, 3 }));
            Console.WriteLine(solution(new int[] { 1 }));
            Console.WriteLine(solution(new int[0]));

            Console.WriteLine("Press anykey to exit.");
            Console.ReadKey();

        }



        public static int solution(int[] A)
        {
            // Empty array means the missing element is the first possible range value.
            if (A.Length == 0)
            {
                return 1;
            }
            else if (A.Length == 1)
            {
                // Only one value means we are likely to be 1 or 2
                if (A[0] == 1)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                // List is unsorted, so lets sort.
                Array.Sort(A);

                for (int i = 0; i <= A.Length; i++)
                {
                    // The next element is a jump.
                    if (A[i] + 1 != A[i + 1])
                    {
                        return A[i] + 1;
                    }
                }

                // No gap was found between values. So we need find it at start or end.
                if (A.Min() == 1)
                {
                    return A.Max() + 1;
                }
                else
                {
                    return 1;
                }
            }            
        }
    }
}
