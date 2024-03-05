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
        public List<int> Play()
        {
            // initialise a new list 
            List<int> dieList = new List<int>();
            //roll dice three times and add values to the list 
            for (int count = 0; count < 3; count++) 
            {
                Die die = new Die();
                //set DieValue to the value given by the dice roll
                die.DieValue = die.Roll();
                //add value to list 
                dieList.Add(die.DieValue);
            }
            //return the list 
            return dieList;
        }
    }
}
