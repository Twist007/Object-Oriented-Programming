using Empires.Charachters;
using Empires.Enums;

namespace Empires.Models.Buildings
{
    public class Barracks : Building
    {
        private const string BarracksUnitType = "Swordsman";
        private const int BarracksUnitCycleLenght = 4;

        private const ResourceType BarracksResourceType = ResourceType.Steel;
        private const int BarracksResourceCycleLenght = 3;
        private const int BarracksResourceQuantity = 10;

        public Barracks(IUnitFactory unitFactory, IResourseFactory resourseFactory)
            : base(BarracksUnitType, BarracksUnitCycleLenght, BarracksResourceType, BarracksResourceCycleLenght,BarracksResourceQuantity, 
                  unitFactory, resourseFactory)
        {
        }
    }
}
