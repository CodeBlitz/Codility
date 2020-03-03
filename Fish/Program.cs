using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running.");
            Console.WriteLine(solution(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 1, 1, 1, 0 }));
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }


        public static int solution(int[] A, int[] B)
        {            
            int deadFish = 0;
            Stack<int> downStreamFish = new Stack<int>();

            for (int index = 0; index < A.Length; index++)
            {
                // Headed up stream
                if (B[index] == 0)
                {
                    while (downStreamFish.Count > 0)
                    {
                        // One of these fish will die. Just decide which one.
                        deadFish++;

                        // Is down stream bigger than up stream
                        if (downStreamFish.First() > A[index])
                        {
                            // The upstream fish is the one that died. 
                            // All down stream fish are still in school.
                            break;
                        }
                        else
                        {
                            // The up stream fish was bigger, so we remove
                            // the dead downstream fish from the stack.
                            downStreamFish.Pop();
                        }
                    }                    
                }
                else
                {
                    // We only need to count the downstream fish as they are discovered.
                    downStreamFish.Push(A[index]);
                }
            }

            return A.Length - deadFish;
        }
    }
}
