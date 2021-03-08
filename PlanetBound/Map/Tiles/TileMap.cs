using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetBound.Map
{
    public class TileMap
    {
        private TileMap[,] map;

        public TileMap[,] Map
        {
            get { return map; }
            private set { map = value; }
        }
    }
}
