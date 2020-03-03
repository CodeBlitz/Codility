using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSliceSum
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Running.");
            Console.WriteLine(solution(new int[] { 3, 2, -6, 4, 0 }));
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }


        public static int solution(int[] A)
        {
            long maxSingleValue = A.Max();
            long maxSlice = maxSingleValue;

            if (maxSlice > A.Sum())
            {
                maxSlice = A.Sum();

                for (int i = 0; i < A.Length; i++)
                {
                    int maxSliceValue = 0;
                    int slice = 0;

                    for (int s = i; s < A.Length; s++)
                    {
                        slice += A[s];

                        if (slice > maxSliceValue)
                        {
                            maxSliceValue = slice;
                        }
                    }

                    if (maxSliceValue > maxSlice)
                    {
                        maxSlice = maxSliceValue;
                    }
                }
            }

            return (int)maxSlice;
        }
    }
}
