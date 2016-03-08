using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.Engine.Commands
{
    public class AttackCommand:Command
    {
        public AttackCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];

            IStarship attackingShip = null, targetShip = null;

           //todo

            this.p
        }
    }
}