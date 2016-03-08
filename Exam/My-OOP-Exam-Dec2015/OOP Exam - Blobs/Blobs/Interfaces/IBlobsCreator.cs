namespace Blobs.Interfaces
{
    public interface IBlobsCreator
    {
        IBlob CreateBlob(string name, int health, int damage, IBehavior behavior, IAttack attack);
    }
}
