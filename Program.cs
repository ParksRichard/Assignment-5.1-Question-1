
/*
Given an integer x, return true if x is a palindromic number,
false otherwise. 
input x = 121
output = true
input x = -121
output x = false
*/

//convert input from string to int?
//account for non-numbers
//array and reverse?
//verify if input is number? symbols make number not palindrome = whole numbers
//can't end with a 0 for palindrome

namespace Assignment_5._1_Question_1
{
    class Program
    {
        public static bool Palindrome(int x)
        {
            if (x < 0) //no negatives
            {
                return false;
            }

            //if (x <0 || not end in 0?, divisible by ten or whatever it was.

            string numbers = x.ToString();
            string reversedNumber = new string(numbers.Reverse().ToArray());
            //use reverse function to simplify
            return numbers == reversedNumber; 
        }

        //userinput
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            Console.WriteLine("");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                bool isPalindrome = Palindrome(input); 

                if (isPalindrome)
                {
                    Console.WriteLine($"{input} is a palindrome.");
                }

                else
                {
                    Console.WriteLine($"{input} is not a palindrome.");
                }
            }

            else
            //try catch?
            {
                Console.WriteLine("User input does not fit the parameters.");
            }
        }
    }

}
