using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Football_player:Person
    {
        public Football_player(string name, int age) : base(name, age)
        {
        }

        public int Numbder { get; set; }
        public double Height { get; set; }
    }
}
