using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 3, 1, 2, 4, 3 }));
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }


        public static int solution(int[] A)
        {
            if (A.Length == 2)
            {
                return Math.Abs(A[0] - A[1]);
            }
            else
            {
                // Get the total sum of the tape from start to finish.

                int totalSum = A.Sum();
                int rightSideTape = totalSum;
                int leftSideTape = 0;
                //int lowestDifference = Math.Abs(totalSum);
                int lowestDifference = A.Max();

                for (int i = 0; i < A.Length; i++)
                {
                    // Pull the left side segement into the left side counter.
                    leftSideTape = leftSideTape + A[i];
                    rightSideTape = rightSideTape - A[i];

                    int differenceBetweenTapes = Math.Abs(leftSideTape - rightSideTape);

                    if (differenceBetweenTapes < lowestDifference)
                    {
                        lowestDifference = differenceBetweenTapes;
                    }                    
                }

                return lowestDifference;
            }
        }


        public static int solution2(int[] A)
        {
            if (A.Length == 2)
            {
                return Math.Abs(A[0] - A[1]);
            }
            else
            {
                // Get the total sum of the tape from start to finish.

                int totalSum = A.Sum();
                int rightSideTape = totalSum;
                int leftSideTape = 0;
                //int lowestDifference = Math.Abs(totalSum);
                int lowestDifference = A.Max();

                for (int i = 0; i < A.Length; i++)
                {
                    // Pull the left side segement into the left side counter.
                    leftSideTape = leftSideTape + A[i];
                    rightSideTape = rightSideTape - A[i];

                    int differenceBetweenTapes = Math.Abs(leftSideTape - rightSideTape);

                    if (differenceBetweenTapes < lowestDifference)
                    {
                        lowestDifference = differenceBetweenTapes;
                    }
                }

                return lowestDifference;
            }
        }
    }
}
