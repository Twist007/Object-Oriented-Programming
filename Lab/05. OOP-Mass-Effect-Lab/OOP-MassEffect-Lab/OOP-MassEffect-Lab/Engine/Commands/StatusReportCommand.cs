using System;
using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.Engine.Commands
{
    public class StatusReportCommand:Command

{
        public StatusReportCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            IStarship ship = GameEngine.Starships;
            Console.WriteLine(ship.ToString());
        }
}
}