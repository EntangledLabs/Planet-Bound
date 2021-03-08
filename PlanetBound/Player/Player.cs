using System;
using PlanetBound.Map;

namespace PlanetBound.Player
{
    public class Player
    {
        private Guid pid;
        private string username;
        private Location location;
        private Stats pstats;
        private Avatar avatar;


        public Guid Pid
        {
            get { return pid; }
            private set { pid = value; }
        }
        public string Username
        {
            get { return username; }
            private set { username = value; }
        }
        public Location Location
        {
            get { return location; }
            private set { location = value; }
        }
        public Stats PStats
        {
            get { return pstats; }
            private set { pstats = value; }
        }
        public Avatar Avatar
        {
            get { return avatar; }
            private set { avatar = value; }
        }

        public Player(Guid uuid, string username, Location initLocation, Stats initStats)
        {
            Pid = uuid;
            Username = username;
            Location = initLocation;
            PStats = initStats;
        }

        public Player(Guid uuid, string username, Location initLocation, Stats initStats, Avatar a)
        {
            Pid = uuid;
            Username = username;
            Location = initLocation;
            PStats = initStats;
            Avatar = a;
        }

        // Update method
        public void Update(Location newLocation, Stats newStats, Avatar newAvatar)
        {
            PStats.Update(newStats);
            Location.Update(newLocation);
            Avatar.Update(newAvatar);
        }
    }
}
