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
            testing.Test();

            Game game = new Game();
            List<int> tempList = game.Play();
            for (int count = 0; count < tempList.Count; count++)
            {
                int dieRoll = count + 1;
                Console.WriteLine("Die " + dieRoll + " - " + tempList[count]);
            }
        }
    }
}