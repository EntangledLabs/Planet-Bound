using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetBound.Player
{
    public class Stats
    {
        private enum Roles
        {
            CAPTAIN, MUTINEER, CREWMATE
        }
        public string role { get; set; }
        public int allegiance { get; set; }
        public Stats()
        {

        }

        public int Update(Stats newStats)
        {
            return -1;
        }

    }

    
}
