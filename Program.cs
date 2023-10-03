namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secret_word = "Apple";
            string guess = "";
            int guess_limit = 3;
            int guess_count = 0;
            bool out_of_guesses = false;


            while(guess != secret_word && !out_of_guesses)
            {
                if(guess_count < guess_limit)
                {
                    Console.Write("enter your guess: ");
                    guess = Console.ReadLine();
                    guess_count++;

                }
                else
                {
                    out_of_guesses = true;
                }
                
            }
            if (out_of_guesses)
            {
                Console.WriteLine("You've run out of guesses!!!");
            }
            else
            {
                Console.WriteLine("CONGRATULATIONS!!!");


            }

            //do
            //{
            //    Console.Write("enter your guess: ");
            //    guess = Console.ReadLine();

            //} while (guess != secret_word);

            //Console.WriteLine("you've won!!!");



        }
    }
}