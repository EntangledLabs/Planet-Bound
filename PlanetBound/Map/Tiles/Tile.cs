using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetBound.Map.Tiles
{
    public class Tile
    {
        protected Dictionary<string, int> resources;
        protected Dictionary<string, float> modifiers;
    }

    public class IceTile : Tile
    {
        
    }
}
