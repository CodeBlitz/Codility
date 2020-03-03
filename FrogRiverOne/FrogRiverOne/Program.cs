using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(5, new int[]{ 1,3,1,4,2,3,5,4}));            
            Console.WriteLine("Press key.");
            Console.ReadKey();

        }


        // X is the other side of the river. 0 is the starting position.
        public static int solution(int X, int[] A)
        {
            const int MISSING = 0;
            // Each element of the array A is a second of time.
            // Each value of the Array represents a leaf falling in a position between start and end.
            // X represents the end point path.

            // Non emply arrays only allowed, so a single value is good.
            if (X == 1)
            {
                // Minimum value is 1, and a single value means the first leaf will provide a path.
                // Zero represents the first second.
                return 0;
            }
            else
            {
                int[] leaves = new int[X];

                for (int second = 0; second < A.Length; second++)
                {
                    // Make the leaf has fallen.
                    if (leaves[A[second] - 1] == MISSING)
                    {
                        leaves[A[second] - 1] = 1;

                        // Only check the path if we are at least past the minimum leaves necessary.
                        if (second > X - 2)
                        {
                            if (leaves.Count(leaf => leaf == MISSING) == 0)
                            {
                                return second;
                            }
                        }                        
                    }                    
                }

                // Negative one means the path is never safe for passing.
                return -1;
            }
        }
    }
}
