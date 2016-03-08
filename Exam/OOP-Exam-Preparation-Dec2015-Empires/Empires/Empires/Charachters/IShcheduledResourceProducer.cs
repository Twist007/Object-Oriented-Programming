namespace Empires.Charachters
{
    public interface IShcheduledResourceProducer : IResourceProducer
    {
        bool CanProduceResource { get; }
    }
}
