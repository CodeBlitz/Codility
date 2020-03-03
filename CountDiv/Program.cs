using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running.");
            Console.WriteLine(solution(6, 11, 2));
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }

        public static int solution(int A, int B, int K)
        {
            int countDivisions = 0;

            for (int i = A; i < B; i++)
            {
                if (i > 0 && i >= K)
                {
                    if (i % K == 0)
                    {
                        countDivisions++;
                    }                       
                }
            }
            
            return countDivisions;
        }
    }
}
