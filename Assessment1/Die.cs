using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Die
    {
         //Property
        private int _dieValue;
        public int DieValue 
        {
            get => _dieValue; set => _dieValue = value;
        } 


        //Method
        public int Roll()
        {
            Random rdm = new Random();
            //random number between 1 and 6 
            int num = rdm.Next(1, 7);
            return num;
        }
    }
}

