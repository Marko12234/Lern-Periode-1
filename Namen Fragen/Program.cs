namespace Namen_Fragen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Ihren Namen ein:");
            string userInput = Console.ReadLine();
            Console.WriteLine("Ihr Name ist: " + userInput);
            Console.Read();
           
        }
    }
}