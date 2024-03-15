using System;


namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = 'y';
            Console.WriteLine("Enter a word or a phrase!");

            do
            {
                var input2 = Console.ReadLine();
                if (IsPalindrome(input2))
                {
                    Console.WriteLine("It is palindrome");
                }
                else
                {
                    Console.WriteLine("It is not a palindrome");
                }

                Console.WriteLine("Wanna continue checking? y for yes, n for no...");
                input = Convert.ToChar(Console.ReadLine());

            } while (input == 'y');

        }

        private static bool IsPalindrome(string input)
        {
            var min = 0;
            var max = input.Length - 1;

            while (true)
            {
                if(min > max)
                {
                    return true;
                }

                var a = input[min];
                var b = input[max];

                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if(min > max)
                    {
                        return true;
                    }

                    a = input[min];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }

                    b = input[max];
                }

                if(char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }

        }
    }
}