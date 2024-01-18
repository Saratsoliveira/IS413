//ask users how many times they want to roll the dice

//For the number of times that the user chose
//roll the two dice
// add one to to the tally for that corresponding number



// See https://aka.ms/new-console-template for more information


//int diel = 0;
//int die2 = 0;
//int total = 0;
//int[] rollTotals = new int[13];
//for the number of times that the user specified
//diel = //random number 1-6
//die = //random number 1-6
//total = die + die2;
//rollTotals[total]++;
//Rolls are done
//For every spot in the array (2-12)
//Calculate the percentage of times that number was rolled
//percentage = how many
//times the specific number was rolled / total number of rolls * 100
//Print the number
//For the number of percentage
//Print one asterisk




using System;

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateRolls(numberOfRolls);

        PrintHistogram(results, numberOfRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    static void PrintHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            double percentage = (double)results[i] / totalRolls * 100;
            Console.Write($"{i}: ");

            // Print asterisks based on the percentage
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}

class DiceRoller
{
    private Random random = new Random();

    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13]; // Index 0 is not used

        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int total = die1 + die2;

            results[total]++;
        }

        return results;
    }
}



