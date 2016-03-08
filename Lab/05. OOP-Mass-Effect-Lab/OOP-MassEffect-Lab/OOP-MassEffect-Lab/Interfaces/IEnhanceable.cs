using System.Collections;
using System.Collections.Generic;
using OOP_MassEffect_Lab.GameObjects.Enhancements;

namespace OOP_MassEffect_Lab.Interfaces
{
    public interface IEnhanceable
    {
        IEnumerable<Enhancement> Enhancements { get; }

        void AddEnhancement(Enhancement enhancement);
    }
}