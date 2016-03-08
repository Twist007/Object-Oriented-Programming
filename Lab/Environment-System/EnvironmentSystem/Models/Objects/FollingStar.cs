using System.Collections.Generic;

namespace EnvironmentSystem.Models.Objects
{
    public class FallingStar : MovingObject
    {
        private const char FallingStarImageCharacter = 'O';
        public FallingStar(int x, int y, Point direction)
             : base(x, y, 1, 1, direction)
        {
            this.ImageProfile = new char[,] { { FallingStarImageCharacter } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Ground || hitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            var produceObject = new List<EnvironmentObject>();
            produceObject.Add(new Tail(this.Bounds.TopLeft.X - this.Direction.X, this.Bounds.TopLeft.Y - this.Direction.Y));
            produceObject.Add(new Tail(this.Bounds.TopLeft.X - this.Direction.X * 2, this.Bounds.TopLeft.Y - this.Direction.Y * 2));
            produceObject.Add(new Tail(this.Bounds.TopLeft.X - this.Direction.X * 3, this.Bounds.TopLeft.Y - this.Direction.Y * 3));

            return produceObject;
        }
    }
}
