using System.Collections.Generic;
using Empires.Enums;

namespace Empires.Charachters
{
    public interface IEmpiresData
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);

         IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);

        IDictionary<ResourceType, int> Resources { get; }
    }
}
