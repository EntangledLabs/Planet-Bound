using System;
using PlanetBound.Map;

namespace PlanetBound.Player
{
    public class Player
    {

        private Guid pId;
        private string username;
        private Location location;
        private Stats pStats;

        public Player(Guid uuid, string username, Location initLocation, Stats initStats)
        {
            pId = uuid;
            this.username = username;
            location = initLocation;
            pStats = initStats;
        }

        public void Update(Location newLocation, Stats newStats)
        {
            location.Update(newLocation);
            pStats.Update(newStats);
        }
    }
}
