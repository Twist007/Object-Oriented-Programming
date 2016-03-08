using Empires.Charachters;

namespace Empires.Models.Units
{
    public abstract class Unit : IUnit
    {
        protected Unit(int attackDamage, int health)
        {
            this.AttackDamage = attackDamage;
            this.Health = health;
        }

        public int AttackDamage { get; }

        public int Health { get; }
    }
}
