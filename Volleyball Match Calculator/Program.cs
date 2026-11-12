namespace Volleyball_Match_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFirstT, nameSecondT;
            int firstPoints, secondPoints, totalPoints, differencePoints;
            double percentFirstT, percentSecondT;


            Console.WriteLine("===== VOLLEYBALL MATCH CALCULATOR =====");
            Console.Write("\nPlease enter the name of first team: ");
            nameFirstT = Console.ReadLine();
            Console.Write("Please enter the number of points scored by the first team: ");
            if (!int.TryParse(Console.ReadLine(), out firstPoints))
            {
                Console.WriteLine("\t\t~~~~~~~Error~~~~~~~");
                return;
            }
            Console.Write("\nPlease enter the name of second team: ");
            nameSecondT = Console.ReadLine();
            Console.Write("Please enter the number of points scored by the second team: ");
            if (!int.TryParse(Console.ReadLine(), out secondPoints))
            {
                Console.WriteLine("\t\t~~~~~~~Error~~~~~~~");
                return;
            }

            if (firstPoints < 0 || secondPoints < 0)
            {
                Console.WriteLine("Points cannot be negative!");
                return;
            }

            totalPoints = firstPoints + secondPoints;

            if (totalPoints == 0)
            {
                Console.WriteLine("At least one point must be scored!");
                return;
            }
            differencePoints = firstPoints >= secondPoints ? (firstPoints - secondPoints) : (secondPoints - firstPoints);
            percentFirstT = (double)firstPoints * 100 / totalPoints;
            percentSecondT = 100 - percentFirstT;

            Console.WriteLine("\n===== MATCH STATISTICS =====\n");
            Console.WriteLine($"Team 1: {nameFirstT}");
            Console.WriteLine($"Team 2: {nameSecondT}\n");
            Console.WriteLine($"Total points: {totalPoints}\n");
            Console.WriteLine($"{nameFirstT} points: {firstPoints}");
            Console.WriteLine($"{nameSecondT} points: {secondPoints}\n");
            Console.WriteLine($"Point difference: {differencePoints}\n");
            Console.WriteLine($"{nameFirstT} score percentage: {percentFirstT:F2}%");
            Console.WriteLine($"{nameSecondT} score percentage: {percentSecondT:F2}%\n");
            Console.WriteLine(firstPoints > secondPoints ? $"Winner: {nameFirstT}\n" :
                  firstPoints < secondPoints ? $"Winner: {nameSecondT}\n" :
                  "a draw\n");
            Console.WriteLine("Total points are " + (totalPoints % 2 == 0 ? "even." : "odd."));
            Console.WriteLine("======================================");

        }
    }
}
