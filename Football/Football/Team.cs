using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }     
        private List <Players> ListOfPlayers { get; set; }
        public List <Football_player> Players
        {
            get { return Players; }
            set
            {
                if (value.Count >= 11 && value.Count <= 22)
                    Players = value;
            }
        }
        public double AveragePlayerAge()
        {
            int totalAge = 0;

            foreach (Football_player player in Players)
            {
              totalAge += player.Age;
              }
            return totalAge / Players.Count;
        }
        internal void AddPlayer(Players players)
        {
            
        }
    }
   
}

 