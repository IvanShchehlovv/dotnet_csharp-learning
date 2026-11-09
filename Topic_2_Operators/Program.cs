using System.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Topic_2_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////// Level 1 ////////////////
            ///

            // Task 1
            int a = 15;
            int b = 4;

            Console.WriteLine($"Task 1" +
                $"\n{a + b}" +
                $"\n{a - b}" +
                $"\n{a * b}" +
                $"\n{a / b}" + // деление даст не дробный результат, потому что int отбросит дробную часть
                $"\n{a % b}");


            // Task 2

            int userNumber;
            Console.Write("\nTask 2\nPleasse enter your number: ");
            if (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("~~~~~~~Error~~~~~~~");
                //return;
            }
            Console.WriteLine(userNumber % 2 == 0 ? "Even" : "Odd");


            // Task 3

            decimal balance = 500;
            balance += 200;
            balance -= 100;
            balance *= 2;
            Console.WriteLine("\nTask 3\n" + balance);


            //////////////// Level 2 ////////////////
            ///

            // Task 4

            int userAge;
            Console.Write("\n\tTask 4\n\tPlease enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.WriteLine("\t~~~~~~~Error~~~~~~~");
                //return;
            }
            bool isAdult, isMinor, isTwenty, isYoungAdult;
            isAdult = userAge >= 18;
            isMinor = userAge < 18;
            isTwenty = userAge == 20;
            isYoungAdult = userAge >= 18 && userAge <= 25;


            // Task 5

            bool hasAccount = true;
            bool hasPassword = true;
            bool specialPermission = false;

            bool canLogin = hasAccount && hasPassword || specialPermission;


            // Task 6

            int x = 5;

            a = x++;
            b = ++x;
            int c = x--;

            Console.WriteLine($"\ta = {a}");
            Console.WriteLine($"\tb = {b}");
            Console.WriteLine($"\tc = {c}");
            Console.WriteLine($"\tx = {x}");


            // Task 7

            int userFirstNumber, userSecondNumber;

            Console.Write("\n\tTask 7\n\tPlease enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out userFirstNumber))
            {
                Console.WriteLine("\t~~~~~~~Error~~~~~~~");
                //return;
            }
            Console.Write("\n\tPlease enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out userSecondNumber))
            {
                Console.WriteLine("\t~~~~~~~Error~~~~~~~");
                //return;
            }
            Console.WriteLine(userFirstNumber > userSecondNumber ? userFirstNumber + " is greater" :
                 userSecondNumber > userFirstNumber ? userSecondNumber + " is greater":
                " numbers are equal");


            //////////////// Level 3 ////////////////
            ///

            // Task 8  ...not yet finished

            decimal originalPrice;
            int discount;

            Console.Write("\n\t\tTask 8\n\tPlease enter original price: ");
            if (!decimal.TryParse(Console.ReadLine(), out originalPrice))
            {
                Console.WriteLine("\t\t~~~~~~~Error~~~~~~~");
                //return;
            }
            Console.Write("\n\t\tPlease enter the discount as a percentage: ");
            if (!int.TryParse(Console.ReadLine(), out discount))
            {
                Console.WriteLine("\t\t~~~~~~~Error~~~~~~~");
                //return;
            }

        }
    }
}
