using System.Security.Cryptography;

namespace Zahlengenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                
                Random num = new Random();
                int numberRandom = num.Next(1, 21);
                bool zahlGefunden = false;
                while (zahlGefunden == false)
                {
                    Console.WriteLine("Geben Sie eine Zahl von 1-20 ein: ");
                    int guessedNumber = Convert.ToInt32(Console.ReadLine());
                    if (guessedNumber == numberRandom)

                    {
                        Console.WriteLine("Sie haben richtig geraten!");
                        zahlGefunden = true;
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("Sie haben falsch geraten!");
                        if (guessedNumber > numberRandom)
                        { Console.WriteLine("Sie haben zu hoch geschätzt!"); }
                        else { Console.WriteLine("Sie haben zu tief geschätzt!"); }
                    }
                }
            }
        }
    }
}
