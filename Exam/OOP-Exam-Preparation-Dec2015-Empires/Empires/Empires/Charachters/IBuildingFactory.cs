namespace Empires.Charachters
{
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding (string buildingType,IResourseFactory resourseFactory, IUnitFactory unitFactory);
    }
}
