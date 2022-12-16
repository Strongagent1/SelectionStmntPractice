using System.Diagnostics.Metrics;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
    
            var r = new Random();

            Console.WriteLine("Let's play a number guessing game.  I will give you clues to guess and see if you can\n" +
                     "correctly guess the random number 1 - 1000. Please take your first guess and try to get it in as few as possible! ");
            do
            {               
                var favNumber = r.Next(1, 1000);
                int guessCount = 1;
                bool retry = true;
                do
                {                  

                    var userInput = int.Parse(Console.ReadLine());

                  
                    if (userInput > favNumber)
                    {
                        Console.WriteLine($"Sorry that number is too high. Please try again. ({guessCount} guesses so far.)");
                        //int.Parse(Console.ReadLine());
                        ++guessCount;
                        continue;
                    }

                    else if (userInput < favNumber)
                    {
                        Console.WriteLine($"That number is too low. Please try again. ({guessCount} guesses so far.)");
                        //int.Parse(Console.ReadLine());
                        ++guessCount;
                        continue;
                    }

                    else if (userInput == favNumber)
                    {
                        Console.WriteLine($"Congrats, you guessed it correctly! It took you {guessCount} guesses to get it right.");
                        ++guessCount;

                        Console.WriteLine("Would you like to retry? y/n");
                        string answer = Console.ReadLine().ToLower();

                        if (answer != "y")
                        {
                            retry = false;
                        }
                        break;
                    }

                } while(true);
                
            }while(true);

        }
    }
}
