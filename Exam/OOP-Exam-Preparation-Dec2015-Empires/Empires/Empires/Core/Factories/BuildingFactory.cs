using System;
using Empires.Charachters;
using Empires.Models.Buildings;

namespace Empires.Core.Factories
{
   public class BuildingFactory:IBuildingFactory
    {
       public IBuilding CreateBuilding(string buildingType,IResourseFactory resourseFactory,IUnitFactory unitFactory)
       {
           switch (buildingType)
           {
                case "archery":
                    return new Archery(unitFactory,resourseFactory);
                case "barracks":
                    return new Barracks(unitFactory,resourseFactory);
                default:
                    throw new ArgumentException("Unknown building type.");
            }
       }
    }
}
