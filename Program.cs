using Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;  //varaible to hold user inputed number of rolls
        
        Console.WriteLine("Welcome to the dice throwing simulator!\n"); 
        Console.WriteLine("How many dice rolls would you like to simulate?");

        numRolls = int.Parse(Console.ReadLine());  //gets user input on number of rolls and makes it an integer

        // Pass numRolls to the DiceRoll class with a new instance
        DiceRoll diceRoll = new DiceRoll(numRolls);

        // Get the roll numbers array from the DiceRoll object
        int[] rollNumbers = diceRoll.GetRollNumbers();

        //result output wording:
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

        // Print the tally counts for each number from 2 to 12 with asterisks of percentage
        for (int i = 0; i < rollNumbers.Length; i++)
        {
            Console.Write($"{i + 2}: ");
            for (int j = 0; j < ((double)rollNumbers[i] / numRolls) * 100; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine(); //writeline for spacing
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");    
    }
}
