using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 1, 3, 6, 4, 1, 2 }));
            Console.WriteLine("Press key.");
            Console.ReadKey();
        }

        public static int solution(int[] A)
        {            
            if (A.Max() <= 0)
            {
                return 1;
            }
            else
            {
                int[] filteredList = A.Where(a => a > 0).Distinct().OrderBy(i => i).ToArray();

                if (filteredList.Min() > 1)
                {
                    return 1;
                }
                else
                {
                    for (int i = 0; i < filteredList.Length - 1; i++)
                    {
                        if (filteredList[i] + 1 != filteredList[i + 1])
                        {
                            // Gap found.
                            return filteredList[i] + 1;
                        }
                    }

                    return filteredList.Max() + 1;
                }
            }            
        }
    }
}
