internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;

        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.WriteLine("How many dice rolls would you like to simulate?");

        numRolls = int.Parse(Console.ReadLine());
    }
}