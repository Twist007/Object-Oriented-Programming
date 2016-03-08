using Empires.Charachters;
using Empires.Enums;
using Empires.Models;

namespace Empires.Core.Factories
{
    public class ResourceFactory : IResourseFactory
    {
        public IResource CreateResource(ResourceType resourceType, int quantity)
        {
            var resource = new Resource(resourceType, quantity);

            return resource;
        }
    }
}
