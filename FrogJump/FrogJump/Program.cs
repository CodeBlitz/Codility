using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJump
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(solution(10, 85, 30));
            Console.WriteLine(solution(1, 1, 30));
            Console.WriteLine(solution(1, 2, 1));
            Console.ReadKey();

        }

        public static int solution(int startPosition, int targetPosition, int jumpDistance)
        {
            int distanceToTravel = targetPosition - startPosition;

            // X = Y
            if (distanceToTravel == 0)
            {
                return 0;
            }
            else
            {
                // 
                int jumps = distanceToTravel / jumpDistance;


                if (distanceToTravel % jumpDistance == 0)
                {
                    return jumps;
                }
                else
                {
                    return jumps + 1;
                }
            }
        }
    }
}
