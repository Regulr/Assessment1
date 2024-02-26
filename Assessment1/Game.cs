using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public void Play()
        {
            List<int> dieList = new List<int>();
            for (int count = 0; count < 3; count++)
            {
                Die die = new Die();
                die.Roll();
                dieList.Add(die.DieValue);
            }
            Console.WriteLine("1." + dieList[0]);
            Console.WriteLine("2." + dieList[1]);
            Console.WriteLine("3." + dieList[2]);
            Console.WriteLine("Overall you rolled a" + dieList.Sum());
        }
    }
}
