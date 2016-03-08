using System;
using System.Collections.Generic;
using EnvironmentSystem.Models.DataStructures;

namespace EnvironmentSystem.Models.Objects
{
    class Star : EnvironmentObject
    {
        private int updateCount = 0;
        const int StartImageUpdateFreq = 10;
        private static readonly Random Randomizer = new Random();

        private char[] starImageProfiles = new char[] { 'O', '@', '0' };

        public Star(int x, int y)
            : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,] { { 'O' } };
        }

        public Star(Rectangle bounds)
            : base(bounds)
        {
        }

        public override void Update()
        {
            if (this.updateCount == StartImageUpdateFreq)
            {
                int index = Randomizer.Next(0, starImageProfiles.Length);
                this.ImageProfile = new char[,] { { starImageProfiles[index] } };
                this.updateCount = 0;
            }
            updateCount++;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }
    }
}
