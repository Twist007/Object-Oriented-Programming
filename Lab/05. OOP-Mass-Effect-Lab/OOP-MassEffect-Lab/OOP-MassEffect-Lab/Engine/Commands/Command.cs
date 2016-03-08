using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.Engine.Commands
{
    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public abstract void Execute(string[] commandArgs);
    }
}