using Empires.Enums;

namespace Empires.Charachters
{
   public interface IResource
    {
        ResourceType ResourceType { get; }

        int Quantity { get; }
    }
}
