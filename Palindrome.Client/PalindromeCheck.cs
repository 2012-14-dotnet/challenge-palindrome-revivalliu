using System;

namespace Palindrome.Client
{

    public class PalindromeCheck
    {

        public static bool IsPalindrome(string input)
        {
            char[] inputArray = input.ToCharArray();

            int end = inputArray.Length - 1;
            for (int start = 0; start < Math.Floor(Convert.ToDouble(inputArray.Length / 2)); start++)
            {

                if (inputArray[start] != inputArray[end])
                {
                    return false;
                }
                else
                {
                    end--;
                    continue;
                }
            }
            return true;
        }
        public static void Main()
        {
            Console.Write("\n\n Recursion : Check whether a string ia Palindrome or not :\n");
            Console.Write("---------------------------------------------------------------\n");
            string str1;
            bool tf;

            Console.Write(" Input: ");
            str1 = Console.ReadLine();
            tf = IsPalindrome(str1);
            if (tf == true)
            {
                Console.WriteLine(" The input is Palindrome.\n");
            }
            else
            {
                Console.WriteLine(" The input is not a Palindrome.\n");
            }
        }

        /* if (input.Length <= 1)
             return true;
         else
         {
             if ( input[0] != input[ input.Length - 1 ] )
                 return false;
             else
                 return IsPalindrome( input.Substring( 1, input.Length-2 ) );
         } */


    }
}
