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
        private bool dead;


        // Field properties

        public string Role
        {
            get { return role; }
            private set { role = value; }
        }
        
        public int Allegiance {
            get { return allegiance; }
            private set { allegiance = value; }
        }

        public bool Dead
        {
            get { return dead; }
            private set { dead = value; }
        }

        // Default constructor
        public Stats(string role, int allegiance)
        {
            this.role = role;
            this.allegiance = allegiance;
        }

        // Class methods

        public void Update(Stats newStats)
        {
            Role = newStats.Role;
        }
    }

    
}
