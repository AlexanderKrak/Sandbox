namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;

            int yesCounter = 0;
            int noCounter = 0;

            

            do
            {
                Console.WriteLine("Whats your answer? Yes or No?");
                
                if(Console.ReadKey().Key == ConsoleKey.Y)
                {
                    yesCounter++;
                }
                else if(Console.ReadKey().Key == ConsoleKey.N)
                {
                    noCounter++;
                }
                else
                {
                    Console.WriteLine("Invalid answer. Please press just y or n");
                    continue;
                }
                counter--;
                Console.WriteLine();
            } while (counter != 0);
            int total = yesCounter + noCounter;

            double yesPercent = Math.Round(yesCounter * 100.0 / total, 2);
            double noPercent = Math.Round(noCounter * 100.0 / total, 2);

            Console.WriteLine("Yes Counts: " + yesCounter + ", Percentage: " + yesPercent + "%");
            Console.WriteLine("No Counts: " + noCounter + ", Percentage: " + noPercent + "%");

            if (yesCounter > noCounter)
            {
                Console.WriteLine("Yes won");
            }
            else if(noCounter > yesCounter)
            {
                Console.WriteLine("No won");
            }
            else
            {
                Console.WriteLine("Draw");
            }

      
        }
    }
}
