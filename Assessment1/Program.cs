using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
            */

            Testing testing = new Testing();
            //run tests 
            testing.Test();

            Game game = new Game();
            //initialise list based on list returned from game.Play()
            List<int> tempList = game.Play();
            //loop through the list and output values 
            for (int count = 0; count < tempList.Count; count++)
            {
                //for each die roll to use in output 
                int dieRoll = count + 1;
                //output each Die Roll
                Console.WriteLine("Die " + dieRoll + " - " + tempList[count]);
            }
            //output the sum of all dice rolls 
            Console.WriteLine("Sum of Dice Rolls - " + tempList.Sum());
        }
    }
}
