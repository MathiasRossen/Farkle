using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class Game
    {
        List<Seat> seats;
        List<Dice> dies;
        List<Player> players;

        Seat currentSeat;

        public bool GameConcluded
        {
            get
            {
                for (int i = 0; i < seats.Count; i++)
                {
                    if (seats[i].Score >= 10000)
                        return true;
                }

                return false;
            }
        }

        public Game()
            :this(6)
        {
        }

        public Game(int numSeats)
        {
            seats = new List<Seat>();
            dies = new List<Dice>();
            players = new List<Player>();

            InitializeGame(numSeats);
            GameLoop();
        }

        private void InitializeGame(int numSeats)
        {
            for (int i = 0; i < numSeats; i++)
            {
                seats.Add(new Seat(i + 1));
            }

            for (int i = 0; i < 6; i++)
            {
                dies.Add(new Dice());
            }

            currentSeat = seats[0];
            currentSeat.Turn = true;
        }

        private void GameLoop()
        {
            while (!GameConcluded)
            {

            }
        }

        public void RollDies()
        {
            for (int i = 0; i < dies.Count; i++)
            {
                dies[i].Roll();
            }
        }

        public void LockDice(int number)
        {
            dies[number - 1].Locked = true;
        }

        public void NextPlayer()
        {
            bool found = false;
            Seat seatSearch;

            while (!found)
            {
                if (currentSeat.Id == seats.Count)
                    seatSearch = seats[0];
            }
        }


    }
}
