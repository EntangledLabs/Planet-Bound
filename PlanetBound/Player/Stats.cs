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
        private Dictionary<string, int> inventory;

        /*
         * Stone: Used to build bases
         * Metal: Used to reinforce bases and make parts
         * Electronics: Used to make communications
         * Plastic: Used for repairs
         * Water: Used for oxygen, fuel
         */

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
        public Dictionary<string,int> Inventory
        {
            get { return inventory; }
            private set { inventory = value; }
        }

        // Default constructor

        public Stats(string role, int allegiance)
        {
            Role = role;
            Allegiance = allegiance;
            Dead = false;
            inventory = new Dictionary<string, int>()
            {
                {"Stone", 0},
                {"Metal", 0},
                {"Electronics", 0},
                {"Plastic", 0},
                {"Water", 10}
            };
        }

        // Class methods

        public void Update(Stats newStats)
        {
            Role = newStats.Role;
            Allegiance = newStats.Allegiance;
            Dead = newStats.Dead;
            Inventory["Stone"] = newStats.Inventory["Stone"];
            Inventory["Metal"] = newStats.Inventory["Metal"];
            Inventory["Electronics"] = newStats.Inventory["Electronics"];
            Inventory["Plastic"] = newStats.Inventory["Plastic"];
            Inventory["Water"] = newStats.Inventory["Water"];
        }
    }
}
