using OOP_MassEffect_Lab.GameObjects.Locations;

namespace OOP_MassEffect_Lab.Interfaces
{
    public interface IStarship:IEnhanceable
    {
         string Name { get; set; }

        int  Health { get; set; }

        int Damage { get; set; }

        double Fuel { get; set; }

        StarSystem Location { get; set; }

        IProjectile ProduceAttack();

        void RespondToAttack(IProjectile attack);
    }
}