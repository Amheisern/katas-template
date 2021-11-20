using System;

namespace Solution
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            // if the number modulus 2 is equal to 0 
            if (number % 2 == 0)
            {
                //return even
                return "Even";
            }
            // Else return odd
            else
            {
                return "odd";
            }
        }
    }
}