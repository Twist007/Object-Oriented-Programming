using System;
using System.Collections.Generic;
using Blobs.Interfaces;

namespace Blobs.Core
{
    public class BlobsData:IBlobsData
    {
        private readonly ICollection<IBlob> blobs=new List<IBlob>();

        public BlobsData()
        {

        }

        public IEnumerable<IBlob> Blobs
        {
            get
            {
                return this.blobs;
            }
        }

        public void AddBlobs(IBlob blobsParam)
        {
            if (blobsParam==null)
            {
                throw new ArgumentNullException(nameof(blobsParam));
            }
            this.blobs.Add(blobsParam);
        }
    }
}
