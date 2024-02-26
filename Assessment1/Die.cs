using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Die
    {
        public int DieValue { get; set; }

        //Method
        public int Roll()
        {
            Random rdm = new Random();
            int num = rdm.Next(1, 7);
            return num;
        }

    }
}

