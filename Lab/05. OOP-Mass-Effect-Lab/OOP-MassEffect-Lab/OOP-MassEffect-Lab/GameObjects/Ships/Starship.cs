using System;
using System.Collections.Generic;
using System.Text;
using OOP_MassEffect_Lab.GameObjects.Enhancements;
using OOP_MassEffect_Lab.GameObjects.Locations;
using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.GameObjects.Ships
{
    public abstract class Starship : IStarship
    {
        private string name;
        private int health;
        private int shields;
        private int damage;
        private double fuel;

        protected Starship(string name, int health, int shields, int damage, double fuel, StarSystem location)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be empty!");
                }
                this.name = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health can not be negativ!");
                }
                this.health = value;
            }
        }

        public int Shields
        {
            get { return this.shields; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Shields can not be negativ!");
                }
                this.shields = value;
            }
        }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Damage can not be negativ!");
                }
                this.damage = value;
            }
        }

        public double Fuel
        {
            get { return this.fuel; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Fuel can not be negativ!");
                }
                this.fuel = value;
            }
        }

        public StarSystem Location { get; set; }

        public abstract IProjectile ProduceAttack();

        public abstract void RespondToAttack(IProjectile attack);

        private IList<Enhancement> enhancements;

        public IEnumerable<Enhancement> Enhancements
        {
            get
            {
                return this.enhancements;
            }
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            if (enhancement == null)
            {
                throw new ArgumentException("Enhancement cannot be null");
            }
            this.enhancements.Add(enhancement);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("--{0} - {1}", this.Name, this.GetType().Name));

            if (this.Health <= 0)
            {
                Console.Out.WriteLine("(Destroyed)");
            }
            else
            {
                output.AppendLine(string.Format("-Location: {0}", this.Location.Name));
                output.AppendLine(string.Format("Health: {0}", this.Health));
                output.AppendLine(string.Format("Shields: {0}", this.Shields));
                output.AppendLine(string.Format("Damage: {0}", this.Damage));
                output.AppendLine(string.Format("Fuel: {0}", this.Fuel));
                foreach (var enhancement in Enhancements)
                {
                    output.AppendLine(string.Format("-Enhancements: {0}", enhancement));
                }
            }
            return output.ToString();
        }
    }
}