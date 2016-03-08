using System;
using Blobs.Interfaces;
namespace Blobs.Models
{
    public class Blob : IBlob
    {
        private string name;
        private int health;
        private int attackDamage;
        private IBehavior behavior;
        private IAttack attack;

        public Blob(string name, int health, int attackDamage, IBehavior behavior, IAttack attack)
        {
            this.behavior = behavior;
            this.attack = attack;
            this.AttackDamage = attackDamage;
            this.Health = health;
            this.Name = name;
        }

        public IBehavior Behavior
        {
            get
            {
                return this.behavior;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Blob should have behavior.");
                }
                this.behavior = value;
            }
        }

        public IAttack Attack
        {
            get
            {
                return this.attack;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Blob should have attack.");
                }
                this.attack = value;
            }
        }

        public int AttackDamage
        {
            get
            {
                return this.attackDamage;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Attack cannot be negative!");
                }
                this.attackDamage = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Health cannot be negative!");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public void ProduceAttack()
        {
            
        }

    }
}
