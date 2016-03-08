using System;
using OOP_MassEffect_Lab.GameObjects.Locations;
using OOP_MassEffect_Lab.GameObjects.Ships;
using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.Engine.Factories
{
    public class ShipFactory
    {
        public IStarship CreateShip(StarshipType type, string name, StarSystem location)
        {
            switch (type)
            {
                case StarshipType.Frigate:
                    return new Frigate(name, location);
                case StarshipType.Cruiser:
                    return new Cruiser(name, location);
                case StarshipType.Dreadnought:
                    return new Dreadnought(name, location);
                default:
                    throw new NotImplementedException("Starship type not implemented");
            }
        }
    }
}