using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number to find binary gap.");
            int NumberValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(NumberValue, 2));
            Console.WriteLine(solution(NumberValue));

            Console.WriteLine("Complete. Press any key to exit.");
            Console.ReadKey();
        }



        public static int solution(int N)
        {
            // Number to bineary conversion.
            string numberBinary = Convert.ToString(N, 2);

            char[] stringArray = numberBinary.ToCharArray();

            // Loop through the string number.
            bool firstOneFound = false;
            int maximumBinaryGap = 0;
            int currentGap = 0;

            foreach (char binaryString in stringArray)
            {
                // Check for start or end of gap.
                if (binaryString.Equals('1'))
                {
                    firstOneFound = true;

                    // Assign the maximum gap as the previous gap.
                    if (currentGap > maximumBinaryGap)
                    {
                        maximumBinaryGap = currentGap;
                    }
                    
                    // Reset gap.
                    currentGap = 0;
                }
                else
                {
                    // We found a zero so the gap is growing.
                    if (firstOneFound)
                    {
                        // The current gap is growing with each zero found.
                        currentGap++;
                    }
                }
            }

            return maximumBinaryGap;
        }
    }
}
