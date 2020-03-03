using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running.");

            Console.WriteLine(solution(String.Empty));

            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }


        public static int solution(string S)
        {            
            const string OPENBRACKETS = "({[";
            const string CLOSINGBRACKETS = ")}]";

            
            bool foundBracketPair = false;


            while (S.Length > 0)
            {
                foundBracketPair = false;

                if (S.Length == 1)
                {
                    return 0;
                }
                else
                {
                    // Search for and remove a pair of brackets.
                    for (int i = 0; i < S.Length - 1; i++)
                    {
                        // Check if the next char is the closing bracket of the current character.
                        int openBracket = OPENBRACKETS.IndexOf(S[i]);

                        if (openBracket != -1)
                        {
                            if (S[i + 1].Equals(CLOSINGBRACKETS[openBracket]))
                            {
                                // We found a zero lenght string with proper brackets surrounding it.
                                string removedBrackets = S.Remove(i, 2);
                                S = removedBrackets;

                                foundBracketPair = true;
                                break;
                            }
                        }
                    }

                    if (!foundBracketPair)
                    {
                        return 0;
                    }
                }
            };

            return 1;            
        }

    }
}
