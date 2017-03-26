using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class Dice
    {
        Random rand;

        public int CurrentState { get; private set; }
        public bool Locked { get; set; }

        public Dice()
        {
            rand = new Random();
        }

        public void Roll()
        {
            CurrentState = rand.Next(6) + 1;
        }
    }
}
