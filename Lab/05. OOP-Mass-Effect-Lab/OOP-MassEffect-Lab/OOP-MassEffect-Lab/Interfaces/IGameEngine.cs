using System.Collections;
using System.Collections.Generic;
using OOP_MassEffect_Lab.Engine.Factories;
using OOP_MassEffect_Lab.GameObjects;

namespace OOP_MassEffect_Lab.Interfaces
{
    public interface IGameEngine
    {
       ShipFactory ShipFactory { get; }
        
        EnhancementFactory EnhancementFactory { get; }  

        IList<IStarship> Starships { get; }

        Galaxy Galaxy { get; }

        ICommandManager CommandManager { get; }

        bool IsRunning { get; set; }

        void Run();

    }
}