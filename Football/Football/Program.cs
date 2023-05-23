using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Team team1 = new Team();
            Team team2 = new Team();
          
      


            Console.ReadLine();

            Players[] players = new Players[22];

            for (int i = 0; i < 22; i++)
            {
                //players[i] = new Players { Name = "Player " + (i + 1) };
            }

            for (int i = 0; i < 11; i++)
            {
                team1.AddPlayer(players[i]);
            }

            for (int i = 11; i < 22; i++)
            {
                team2.AddPlayer(players[i]);
            }

        }
    }
}
