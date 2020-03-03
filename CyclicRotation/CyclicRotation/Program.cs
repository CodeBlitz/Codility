using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[10] { 1,2,3,4,5,6,7,8,9,10};

            foreach (int i in myArray)
            {
                Console.Write(@"{0}, ", i);
            }

            Console.WriteLine("Enter number to shift 0.");

            int[] returnedArray = solution(myArray, 0);

            foreach (int i in returnedArray)
            {
                Console.Write(@"{0}, ", i);
            }

            Console.WriteLine("Finished.");
            Console.ReadKey();        
        }


        public static int[] solution(int[] A, int K)
        {
            // Create new array.
            int[] shiftedArray = new int[A.Count()];
            int remainder;
            int shiftDiff;

            if (A.Count() == 0 || K == 0)
            {
                return A;
            }
            else
            {
                // Check for a 360 degree shift.
                if (K > A.Count())
                {
                    // Get remainder of shifts from count.
                    // A - K = amount to take from start to use as end.
                    remainder = K % A.Count();
                }
                else
                {
                    // This is 3.
                    remainder = K;
                }

                // This is 2.
                shiftDiff = A.Count() - remainder;

                // From end and use as beginning.
                Array.Copy(A, shiftDiff, shiftedArray, 0, remainder);

                // Take from beginning and use as end.
                Array.Copy(A, 0, shiftedArray, remainder, shiftDiff);

                return shiftedArray;
            }
        }
    }
}
