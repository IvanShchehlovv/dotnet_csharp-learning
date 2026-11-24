namespace Topic_3_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////// Level 1 ////////////////
            ///

            // Task 1

            int userAge;
            Console.Write("Please enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out userAge) || userAge < 0)
            {
                Console.WriteLine("Error");
                //return;
            }
            else if (userAge <= 17)
            {
                Console.WriteLine("You are a Minor.");
            }
            else if (userAge <= 64)
            {
                Console.WriteLine("You are an Adult.");
            }
            else
            {
                Console.WriteLine("You are a Senior.");
            }

            // Task 2
            int userInt;
            Console.Write("\nPlease enter an integer: ");
            if (!int.TryParse(Console.ReadLine(), out userInt))
            {
                Console.WriteLine("Error");
                //return;
            }
            else if (userInt < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (userInt > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Zero");
            }


            // Task 3
            int userNumber1, userNumber2, userNumber3;
            Console.WriteLine("\nEnter three numbers: ");
            if (!int.TryParse(Console.ReadLine(), out userNumber1) ||
                !int.TryParse(Console.ReadLine(), out userNumber2) ||
                !int.TryParse(Console.ReadLine(), out userNumber3))
            {
                Console.WriteLine("Error");
                //return;
            }
            else if (userNumber1 > userNumber2 && userNumber1 > userNumber3)
            {
                Console.WriteLine("The largest number is: " + userNumber1);
            }
            else if (userNumber2 > userNumber1 && userNumber2 > userNumber3)
            {
                Console.WriteLine("The largest number is: " + userNumber2);
            }
            else if (userNumber3 > userNumber1 && userNumber3 > userNumber2)
            {
                Console.WriteLine("The largest number is: " + userNumber3);
            }
            else
            {
                Console.WriteLine("There is a tie for the largest number.");
            }


            //////////////// Level 2 ////////////////
            ///

            // Task 4

            int age = 20;
            bool hasAccount = true;
            bool isBlocked = false;

            if (age >= 18 && hasAccount && !isBlocked)
            {
                Console.WriteLine("\n\n\tAccess granted");
            }
            else
            {
                Console.WriteLine("\n\n\tAccess denied");
            }

            if (hasAccount)
            {
                if (!isBlocked)
                {
                    if (age >= 18)
                    {
                        Console.WriteLine("\n\n\tAccess granted");
                    }
                    else
                    {
                        Console.WriteLine("\n\n\tAccess denied: You must be at least 18 years old.");
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\tAccess denied: Your account is blocked.");
                }
            }
            else
            {
                Console.WriteLine("\n\n\tAccess denied: You must have an account.");
            }


            // Task 5

            int userScore;
            Console.Write("\n\tPlease enter a score ranging from 0 to 100: ");
            if (!int.TryParse(Console.ReadLine(), out userScore) ||
                userScore < 0 || userScore > 100)
            {
                Console.WriteLine("\tInvalid score");
                //return;
            }
            else if (userScore <= 59)
            {
                Console.WriteLine("\tFailed");
            }
            else if ( userScore <= 74)
            {
                Console.WriteLine("\tSatisfactory");

            }
            else if (userScore <= 89)
            {
                Console.WriteLine("\tGood");
            }
            else
            {
                Console.WriteLine("\tExellent");
            }

            // Task 6

            decimal purchasePrice;
            bool isStudent;

            Console.Write("\n\tPlease enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out userAge) || userAge < 0)
            {
                Console.WriteLine("Error");
                //return;
            }
            Console.Write("\tPlease enter a purchase price: ");
            if (!decimal.TryParse(Console.ReadLine(), out purchasePrice) || purchasePrice < 0)
            {
                Console.WriteLine("Error");
                //return;
            }
            Console.Write("\tAre you a student? [y/n] ");
            isStudent = Console.ReadLine()?.Trim().ToLower() == "y";

            if (userAge <= 18)
            {
                Console.WriteLine("The final price = " + (purchasePrice - purchasePrice / 10));
            }
            else if (isStudent && userAge <= 25)
            {
                Console.WriteLine("The final price = " + (purchasePrice - (purchasePrice / 100) * 15));
            }
            else
            {
                Console.WriteLine("The final price = " + purchasePrice);
            }


            //////////////// Level 3 ////////////////
            ///

            // Task 7

            int userChoice;

            Console.WriteLine("\n\n\t\t===== MENU =====");
            Console.WriteLine($"\t\t1. Start\n\t\t2. Settings\n\t\t3. Profile\n\t\t4. Exit");
            Console.Write("Your choice: ");
            
            int.TryParse(Console.ReadLine(), out userChoice);

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("\t\tStart");
                    break;

                case 2:
                    Console.WriteLine("\t\tSettings");
                    break;

                case 3:
                    Console.WriteLine("\t\tProfile");
                    break;

                case 4:
                    Console.WriteLine("\t\tExit");
                    break;

                default:
                    Console.WriteLine("\t\tError");
                    break;
            }


            // Task 8

            int userNumberMonth;

            Console.Write("\n\n\t\tPlease enter the number of month");

            int.TryParse(Console.ReadLine(), out userNumberMonth);

            switch (userNumberMonth)
            {
                case 12 or 1 or 2:
                    Console.WriteLine("\t\tWinter");
                    break;

                case 3 or 4 or 5:
                    Console.WriteLine("\t\tSpring");
                    break;

                case 6 or 7 or 8:
                    Console.WriteLine("\t\tSummer");
                    break;

                case 9 or 10 or 11:
                    Console.WriteLine("\t\tAutumn");
                    break;

                default:
                    Console.WriteLine("\t\tError");
                    break;
            }


            // Task 9

            int userAssessment;

            Console.Write("\n\n\t\tPlease enter a rating on a scale of 0 to 100");
            int.TryParse(Console.ReadLine(), out userAssessment);

            string result = userAssessment switch
            {
                >= 0 and <= 59 => "\t\tFailed",
                >= 60 and <= 74 => "\t\tSatisfactory",
                >= 75 and <= 89 => "\t\tGood",
                >= 90 and <= 100 => "\t\tExcellent",
                _ => "Invalid"
            };
            
            Console.WriteLine(result);

            // Task 10

            int temperature = 25;
            switch (temperature)
            {
                case < 0:
                    Console.WriteLine("\n\n\t\tFreezing");
                    break;

                case >= 0 and <= 15:
                    Console.WriteLine("\n\n\t\tCold");
                    break;

                case >= 16 and <= 25:
                    Console.WriteLine("\n\n\t\tWarm");
                    break;

                case > 25:
                    Console.WriteLine("\n\n\t\tHot");
                    break;

                default:
                    Console.WriteLine("\n\n\t\tError");
                    break;
            }

        }
    }
}
