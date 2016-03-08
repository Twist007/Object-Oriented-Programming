using System.Collections;
using System.Collections.Generic;

namespace Blobs.Interfaces
{
    public interface IBlobsData
    {
        IEnumerable<IBlob> Blobs { get; }

        void AddBlobs(IBlob blobsParam);
    }
}
