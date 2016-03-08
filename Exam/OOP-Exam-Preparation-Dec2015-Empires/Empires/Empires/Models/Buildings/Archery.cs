using Empires.Charachters;
using Empires.Enums;

namespace Empires.Models.Buildings
{
    public class Archery : Building
    {
        private const string ArcheryUnitType = "Archer";
        private const int ArcheryUnitCycleLenght = 3;

        private const ResourceType ArcheryResourceType = ResourceType.Gold;
        private const int ArcheryResourceCycleLenght = 2;
        private const int ArcheryRseourceQuantity = 5;

        public Archery( IUnitFactory unitFactory, IResourseFactory resourseFactory)
             : base(ArcheryUnitType, ArcheryUnitCycleLenght, ArcheryResourceType, ArcheryResourceCycleLenght,ArcheryRseourceQuantity,
                   unitFactory, resourseFactory)
        {
        }
    }
}
