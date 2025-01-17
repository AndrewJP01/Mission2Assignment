using Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;
        

        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.WriteLine("How many dice rolls would you like to simulate?");

        numRolls = int.Parse(Console.ReadLine());
        //testing git

        // Pass numRolls to the DiceRoll class
        DiceRoll diceRoll = new DiceRoll(numRolls);

        // Get the roll numbers array from the DiceRoll object
        int[] rollNumbers = diceRoll.GetRollNumbers();

        // Print the tally counts for each number from 2 to 12
        for (int i = 0; i < rollNumbers.Length; i++)
        {
            Console.Write($"{i + 2}: ");
            for (int j = 0; j < ((double)rollNumbers[i] / numRolls) * 100; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
