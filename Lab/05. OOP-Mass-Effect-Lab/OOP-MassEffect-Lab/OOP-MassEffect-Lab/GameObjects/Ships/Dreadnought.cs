using OOP_MassEffect_Lab.GameObjects.Locations;
using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.GameObjects.Ships
{
    public class Dreadnought : Starship
    {
        public Dreadnought(string name, StarSystem location) 
            : base(name, 200, 300, 150, 700, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            throw new System.NotImplementedException();
        }

        public override void RespondToAttack(IProjectile attack)
        {
            throw new System.NotImplementedException();
        }
    }
}