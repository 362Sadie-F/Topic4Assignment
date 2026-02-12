using System.Security.Cryptography.X509Certificates;

namespace Topic4Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double price;
            Console.WriteLine("Hello there! What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("It's a pleasure to meet you, " + name + ", what about your age?");
            Console.WriteLine (Int32.TryParse (Console.ReadLine(), out age));
            Console.WriteLine("Well that's interesting! " + age + ", huh? And what about how much you make?");
            double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine(price.ToString("C") + "? Sure hope that's by the hour and not weekly!");

        }
    }
}
