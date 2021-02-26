using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetBound.Player
{
    public class Stats
    {
        // Fields

        private enum Roles
        {
            CAPTAIN, MUTINEER, CREWMATE
        }
        private string role;
        private int allegiance;


        // Field properties

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public int Allegiance { get; private set; }

        // Default constructor
        public Stats()
        {

        }

        // Class methods

        public void Update(Stats newStats)
        {
            Role = newStats.Role;
        }

    }

    
}
