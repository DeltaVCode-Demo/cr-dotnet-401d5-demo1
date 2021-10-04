using System;

namespace MyFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 42;

            Console.WriteLine("Hello World! {0} is a good number", number);

            DoSomething();
        }

        static void DoSomething()
        {
            try
            {
                int favNumber = PromptForFavoriteNumber();

                MakeSureNotSeven(favNumber);

                double fiveDividedByFav = 5 / favNumber;

                Console.WriteLine("Five divided by {0} = {1}", favNumber, fiveDividedByFav);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That was not a number, dummy. " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // Any exception we haven't handled already
            {
                Console.WriteLine("SOmething else went wrong: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This will always output, rain or shine.");
            }
        }

        private static int PromptForFavoriteNumber()
        {
            // like JS prompt - get a string from the user
            Console.Write("What is your favorite number? ");
            string input = Console.ReadLine();

            // just like parseInt in JS
            int favNumber = Convert.ToInt32(input);
            return favNumber;
        }

        private static void MakeSureNotSeven(int favNumber)
        {
            if (favNumber == 7)
            {
                throw new ApplicationException("That is cliche.");
            }
        }
    }
}
