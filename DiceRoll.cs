using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class DiceRoll
    {
        int[] rollNumbers = new int[11]; //array that holds the roll counts 2 through 12
        public DiceRoll(int numRolls)
        {
            Random random = new Random();  // Create a Random object

            // iterates the amount of rolls and does the logic
            for (int i = 0; i < numRolls; i++)
            {
                int randomNumber1 = random.Next(1, 7); //random number between 1 and 6 for dice 1
                int randomNumber2 = random.Next(1, 7); //random number between 1 and 6 for dice 2

                int rollCombo = randomNumber1 + randomNumber2; //roll combo is the rolls of both dice

                rollNumbers[rollCombo - 2]++; //gets the roll number put in the correct spot

            }
        }

        // Method to return the roll numbers array
        public int[] GetRollNumbers()
        {
            return rollNumbers;  // Return the rollNumbers array
        }
    }
}
