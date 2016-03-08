using System;
using System.Linq;
using OOP_MassEffect_Lab.Engine.Factories;
using OOP_MassEffect_Lab.GameObjects.Enhancements;
using OOP_MassEffect_Lab.GameObjects.Ships;
using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.Engine.Commands
{
    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string type = commandArgs[1];
            string shipName = commandArgs[2];
            string locationName = commandArgs[3];

            bool shipAlreadyExists = this.GameEngine.Starships.
                Any(ss => ss.Name == shipName);

            if (shipAlreadyExists)
            {
                throw new
            }

            var location = this.GameEngine.Galaxy.GetStarSystemByName(locationName);
            StarshipType shipType = (StarshipType)Enum.Parse(typeof(StarshipType), type);

            ShipFactory shipFactory = new ShipFactory();
           var ship = shipFactory.CreateShip(shipType, shipName, location);

            //TODO: ADD SHIP TO STARSHIPS IN THE GAMEENGINE

            for (int i = 0; i < commandArgs.Length; i++)
            {
                var enhancementType = (EnhancementsType)Enum.Parse(typeof(EnhancementsType), commandArgs[i]);
                Enhancement enhancement = null;

                EnhancementFactory enhancementFactory = new EnhancementFactory();
                enhancementFactory.Create(enhancementType);
                ship.AddEnhancement(enhancement);
            }
        }
    }
}