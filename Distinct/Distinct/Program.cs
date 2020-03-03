using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Distinct
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Running.");

            Console.WriteLine(solution(new int[] { 0 }));

            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }

        public static int solution(int[] A)
        {
            //return -1;

            if (A.Length == 0)
            {
                return 0;
            }
            else
            {
                return A.Distinct().Count();
            }

        }
    }
}
