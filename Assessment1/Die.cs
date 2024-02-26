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
        public void Roll()
        {
            Random rdm = new Random();
            DieValue = rdm.Next(0, 7);
        }

    }
}

