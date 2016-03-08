using System;
using OOP_MassEffect_Lab.GameObjects.Enhancements;

namespace OOP_MassEffect_Lab.Engine.Factories
{
    public class EnhancementFactory
    {
        public Enhancement Create(EnhancementsType enhancementsType)
        {
            switch (enhancementsType)
            {
                case EnhancementsType.ThanixCannon:
                    return new Enhancement("ThanixCannon", 0, 50, 0);
                case EnhancementsType.ExtendedFuelCells:
                    return new Enhancement("ExtendedFuelCells", 0, 0, 200);
                case EnhancementsType.KineticBarrier:
                    return new Enhancement("KineticBarrier", 100, 0, 0);
                default:
                    throw new NotImplementedException("Enhancements type not implemented");
            }
        }
    }
}