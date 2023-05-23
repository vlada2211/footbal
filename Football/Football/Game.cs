using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Game
    {
        public Team Team1
        {
            get { return Team1; }
            set
            {
                for (int i = 0; i < 11; i++)
                {
                    Team1 = value;
                };

            }
        }
        public Team Team2 {
            get { return Team2; }

            set
            {
                for (int i = 11; i < 22; i++)
                {
                    Team2 = value;
                };
            }
            }
        public Referee Referee { get; set; }
        public List <string> AssistantReferees { get; set;}
        public List <Tuple<int, Players>> Goals { get; set; }
        public string GameResult { get; set;}
        public string Winner { get; set; }
        public void AddAssistantReferee(string assistantReferee)
        {
            AssistantReferees.Add(assistantReferee);
        }

        public void AddGoal(int minute, Players player)
        {
            Goals.Add(new Tuple<int, Players>(minute, player));
        }
        

    }
}
