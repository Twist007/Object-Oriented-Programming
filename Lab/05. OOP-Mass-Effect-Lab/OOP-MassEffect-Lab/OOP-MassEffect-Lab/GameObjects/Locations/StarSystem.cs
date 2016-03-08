using System.Collections.Generic;

namespace OOP_MassEffect_Lab.GameObjects.Locations
{
    public class StarSystem
    {
        public StarSystem(string name)
        {
            this.Name = name;
            this.NeighbourStarSystems=new Dictionary<StarSystem,double>();
        }

        public Dictionary<StarSystem, double> NeighbourStarSystems { get; set; }

        public string Name { get; set; }
    }
}