using Blobs.Interfaces;
using Blobs.Models;

namespace Blobs.Core
{
    public class BlobsCreater:IBlobsCreator
    {
        public IBlob CreateBlob(string name, int health, int damage, IBehavior behavior, IAttack attack)
        {
            return new Blob(name,health,damage,behavior,attack);
        }
    }
}
