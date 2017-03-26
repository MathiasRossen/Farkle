using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class Seat
    {
        public int Id { get; private set; }
        public Player Player { get; set; }
        public bool Turn { get; set; }
        public bool Occupied { get; set; }
        public int Score { get; private set; }
        public bool CanPlay
        {
            get
            {
                if (Player == null)
                    return false;
                return true;
            }
        }

        public Seat(int id)
        {
            Id = id;
        }

        public void OccupySeat(Player player)
        {
            Player = player;
            Occupied = true;
        }

        public void AddScore(int amount)
        {
            Score += amount;
        }
    }
}
