using System;
using PlanetBound.Map;

namespace PlanetBound.Player
{
    public class Player
    {

        public Guid pId { get; private set; }
        public string username { get; private set; }
        public Location location { get; private set; }
        public Stats pStats { get; private set; }

        public Player(Guid uuid, string username, Location initLocation, Stats initStats)
        {
            pId = uuid;
            this.username = username;
            location = initLocation;
            pStats = initStats;
        }

        public void Update(Location newLocation, Stats newStats)
        {
            pStats.Update(newStats);
            location.Update(newLocation);
        }
    }
}
