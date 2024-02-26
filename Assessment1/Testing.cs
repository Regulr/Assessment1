using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assessment1
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public void Test() 
        {
            Game game = new Game();
            Debug.Assert(game.Play().Sum() > 2 && game.Play().Sum() < 19, "Sum is not within expected peramiters");

            Die die = new Die();
            Debug.Assert(die.Roll() < 7 && die.Roll() > 0, "Dice Rolls are not within expected peramiters");
        }
        
    }
}
