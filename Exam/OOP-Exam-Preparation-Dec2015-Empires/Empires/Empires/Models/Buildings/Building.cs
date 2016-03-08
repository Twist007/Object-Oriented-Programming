using Empires.Charachters;
using Empires.Enums;

namespace Empires.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private const int ProductionDelay = 1;

        private int cycleCount = 0;

        private string unitType;
        private int unitCycleLenght;
        private ResourceType resourceType;
        private int resourceCycleLenght;
        private int resourceQuantity;
        private IUnitFactory unitFactory;
        private IResourseFactory resourseFactory;

        protected Building(string unitType, int unitCycleLenght, ResourceType resourceType, int resourceCycleLenght, int resourceQuantity,
            IUnitFactory unitFactory, IResourseFactory resourseFactory)
        {
            this.unitType = unitType;
            this.unitCycleLenght = unitCycleLenght;
            this.resourceType = resourceType;
            this.resourceCycleLenght = resourceCycleLenght;
            this.resourceQuantity = resourceQuantity;
            this.unitFactory = unitFactory;
            this.resourseFactory = resourseFactory;
            //validation
        }

        public bool CanProduceResource
        {
            get
            {
                bool canProduceResource =this.cycleCount>ProductionDelay&& (this.cycleCount - ProductionDelay)%this.resourceCycleLenght == 0;

                return canProduceResource;
            }
            
        }

        public bool CanProduceUnit
        {
            get
            {
                bool canProduceUnit = this.cycleCount > ProductionDelay && (this.cycleCount - ProductionDelay) % this.unitCycleLenght == 0;

                return canProduceUnit;
            }
        }


        public IResource ProduceResource()
        {
            var resource = this.resourseFactory.CreateResource(this.resourceType, this.resourceQuantity);
            return resource;
        }

        public IUnit ProduceUnit()
        {
            var unit = this.unitFactory.CreateUnit(this.unitType);
            return unit;
        }

        public void Update()
        {
            this.cycleCount++;
        }

        public override string ToString()
        {
            int turnsUntilUnit = this.unitCycleLenght-(this.cycleCount - ProductionDelay) % this.unitCycleLenght;
            int turnsUntilResource = this.resourceCycleLenght - (this.cycleCount - ProductionDelay) % this.resourceCycleLenght; 

            var result = string.Format("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name,
                this.cycleCount - ProductionDelay,
                turnsUntilUnit,
                this.unitType,
                turnsUntilResource,
                this.resourceType);
            return result;
        }
    }
}
