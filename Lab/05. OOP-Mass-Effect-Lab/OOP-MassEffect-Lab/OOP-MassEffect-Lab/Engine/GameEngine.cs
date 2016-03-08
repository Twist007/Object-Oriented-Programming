using System;
using System.Collections.Generic;
using OOP_MassEffect_Lab.Engine.Factories;
using OOP_MassEffect_Lab.GameObjects;
using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.Engine
{
    public class GameEngine: IGameEngine
    {
        public GameEngine(ICommandManager commandManager, Galaxy galaxy)
        {
            this.Galaxy = galaxy;
            this.CommandManager = commandManager;
            this.ShipFactory=new ShipFactory();
            this.EnhancementFactory=new EnhancementFactory();
            this.Starships=new List<IStarship>();
        }

        public ShipFactory ShipFactory { get; private set; }

        public EnhancementFactory EnhancementFactory { get; set; }

        public IList<IStarship> Starships { get; private set; }

        public Galaxy Galaxy { get; private set; }

        public ICommandManager CommandManager { get; set; }

        public bool IsRunning { get; set; }

        public void Run()
        {
            this.IsRunning = true;
            this.CommandManager.Engine = this;
            this.CommandManager.SeedCommands();

            do
            {
                string command = Console.ReadLine();

                try
                {
                    this.CommandManager.ProcessCommand(command);
                }
                catch (ShipException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            } while (this.IsRunning);
        }
    }
}