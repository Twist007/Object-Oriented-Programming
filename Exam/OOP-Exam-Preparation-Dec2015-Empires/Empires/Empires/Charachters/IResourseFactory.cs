using Empires.Enums;

namespace Empires.Charachters
{
    public interface IResourseFactory
    {
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}
