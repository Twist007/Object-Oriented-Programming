using System.Text;
using OOP_MassEffect_Lab.GameObjects.Locations;
using OOP_MassEffect_Lab.Interfaces;

namespace OOP_MassEffect_Lab.GameObjects.Ships
{
    public class Frigate : Starship
    {
        private int projectilesFired;

       public Frigate(string name, StarSystem location) 
            : base(name, 60, 50, 30, 220, location)
        {
        }

        public int ProjectilesFired
        {
            get { return projectilesFired; }
            set { projectilesFired = value; }
        }

        public override IProjectile ProduceAttack()
        {
            throw new System.NotImplementedException();
        }

        public override void RespondToAttack(IProjectile attack)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(base.ToString());
            if (this.Health>0)
            {
                sb.AppendLine(string.Format("-Projectiles fired: {0}", this.ProjectilesFired));
            }

            return sb.ToString();
        }
    }
}