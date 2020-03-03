using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesting
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Running.");
            Console.WriteLine(Program.solution("((((()))))"));
            Console.WriteLine("Press any key.");
            Console.ReadKey();

        }

        public static int solution(string S)
        {
            const char OPENBRACKET = '(';
            
            int countOpen = 0;            

            // Search for and remove a pair of brackets.
            for (int i = 0; i < S.Length; i++)
            {
                // Check if the next char is the closing bracket of the current character.                        
                if (S[i].Equals(OPENBRACKET))
                {
                    // Counting the open brackets.
                    countOpen++;
                }
                else
                {
                    // Found a closing bracket so we can subtract it.
                    countOpen--;
                }

                // Make sure we have not gone negative.
                if (countOpen < 0)
                {
                    return 0;
                }
            }

            // Brackets are balanced so we are nested all the way.
            if (countOpen == 0)
            {
                return 1;
            }
            else
            {
                // Eithere we went negative or positive on open or closed brackets.
                return 0;
            }            
        }




        public static int solutionBad(string S)
        {
            const char OPENBRACKETS = '(';
            const char CLOSINGBRACKETS = ')';

            while (S.Length > 0)
            {
                if (S.Length == 1)
                {
                    return 0;
                }
                else
                {
                    bool foundBracketPair = false;

                    // Search for and remove a pair of brackets.
                    for (int i = 0; i < S.Length - 1; i++)
                    {
                        // Check if the next char is the closing bracket of the current character.                        
                        if (S[i].Equals(OPENBRACKETS))
                        {
                            if (S[i + 1].Equals(CLOSINGBRACKETS))
                            {
                                // A nestd bracket
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
