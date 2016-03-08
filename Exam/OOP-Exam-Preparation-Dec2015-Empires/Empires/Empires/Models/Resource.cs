using Empires.Charachters;
using Empires.Enums;

namespace Empires.Models
{
    public class Resource : IResource
    {
        public Resource(ResourceType resourceType, int quantity)
        {
            this.ResourceType = resourceType;
            this.Quantity = quantity;
        }

        public ResourceType ResourceType { get; }

        public int Quantity { get; }
    }
}
