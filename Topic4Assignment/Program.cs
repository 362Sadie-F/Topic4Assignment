using System.Security.Cryptography.X509Certificates;

namespace Topic4Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string lastName;
            string login;
            int studentID;
            double average;
            int grade;
            int age;
            double price;
            Console.WriteLine("Hello there! What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("It's a pleasure to meet you, " + name + ", what about your age?");
            Console.WriteLine (Int32.TryParse (Console.ReadLine(), out age));
            Console.WriteLine("Well that's interesting! " + age + ", huh? And what about how much you make?");
            double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine(price.ToString("C") + "? Sure hope that's by the hour and not weekly!");
            Console.WriteLine("    ");
            Console.WriteLine("Please enter the following information.");
            Console.Write("First name: ");
            name = Console.ReadLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();
            Console.Write("Grade [9-12]: " );
            grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student ID: ");
            studentID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Grade average: ");
            double.TryParse (Console.ReadLine(), out average);
            Console.WriteLine("Information display: ");
            Console.WriteLine("Login:\t\t" + login);
            Console.WriteLine("ID:\t\t" + studentID);
            Console.WriteLine("Name:\t\t" + lastName + ", " + name);
            Console.WriteLine("Average:\t" + average + "%");
            Console.WriteLine("Grade:\t\t" + grade);
        }
    }
}
