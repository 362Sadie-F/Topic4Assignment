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
            string itemOne;
            string itemTwo;
            int studentID;
            int grade;
            int age;
            double average;
            double price;
            double num1;
            double num2;
            double num3;
            double num4;
            double price1;
            double price2;
            double discount;
            double total1;

            Console.WriteLine("Hello there! What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("It's a pleasure to meet you, " + name + ", what about your age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Well that's interesting! " + age + ", huh? And what about how much you make?");
            double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine(price.ToString("C") + "? Sure hope that's by the hour and not weekly!");
            Console.WriteLine("   ");
            Console.WriteLine("\t\t Press ENTER to continue \t ");
            Console.ReadLine();
            Console.Clear();
           
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
            Console.WriteLine("   ");
            Console.WriteLine("\t\t Press ENTER to continue \t ");
            Console.ReadLine();
            Console.Clear();
          
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello there, " + name + ", how old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you are " + age + " now, you will be " + (age + 5) + " in 5 years");
            Console.WriteLine("In the opposite direction, you were " + (age - 5) + " five years ago.");
            Console.WriteLine("    ");
            Console.WriteLine("\t\t Press ENTER to continue \t ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter 3 numbers below.");
            num1 = Convert.ToInt32(Console.ReadLine()); num2 = Convert.ToInt32(Console.ReadLine()); num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + "+" + num2 + "+" + num3 + " = " + (num1 + num2 + num3));
            num4 = (num1 + num2 + num3);
            Console.WriteLine("Divide by 2 now and your answer is " + (num4 / 2));
            Console.WriteLine("    ");
            Console.WriteLine("\t\t Press ENTER to continue \t ");
            Console.ReadLine();
            Console.Clear();
           
            // name and price of 2 things, total price, discount of 20% subtracted from total, taxes and final price
            Console.Write("Item one: ");
            itemOne = Console.ReadLine();
            Console.Write("Price: $");
            double.TryParse(Console.ReadLine(), out price1);
            Console.Write("Item two: ");
            itemTwo = Console.ReadLine();
            Console.Write("Price: $");
            double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total: " + (price1 + price2));
            total1 = (price1 + price2);
            discount = (total1 / 100) - (20 / 100) * (100);
            Console.WriteLine("20% Discount: " + (total1 - discount));
            Console.WriteLine("SubTotal: " + (discount + total1));
            Console.WriteLine("Tax: ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Final Total: ");
        }
    }
}
