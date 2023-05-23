using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
   public class Goal
    {
        public Goal(double minute) 
        {
            Minute = minute;
        }   
        public double Minute { get; set; }
        public Football_player player { get; set; }
    }
}
