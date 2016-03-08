namespace Blobs.Interfaces
{
    public interface IBlob : IAttacker, IDestroyable
    {
        string Name { get; set; }
    }
}
