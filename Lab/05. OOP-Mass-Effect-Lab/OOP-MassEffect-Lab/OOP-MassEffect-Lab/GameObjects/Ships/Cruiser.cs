using OOP_MassEffect_Lab.GameObjects.Locations;
using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.GameObjects.Ships
{
    public class Cruiser : Starship
    {
        public Cruiser(string name, StarSystem location) 
            : base(name, 100, 100, 50, 300, location)
        {
        }


        public override IProjectile ProduceAttack()
        {
            throw new System.NotImplementedException();
        }
    }
}