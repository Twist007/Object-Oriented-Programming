namespace OOP_MassEffect_Lab.GameObjects.Enhancements
{
    public class Enhancement
    {
        private string name;
        private int shieldBonus;
        private int damageBonus;
        private int fuelBonus;

        public Enhancement(string name, int shieldBonus, int damageBonus, int fuelBonus)
        {
            this.Name = name;
            this.ShieldBonus = shieldBonus;
            this.DamageBonus = damageBonus;
            this.FuelBonus = fuelBonus;
        }

        public string Name { get; private set; }

        public int ShieldBonus { get; private set; }

        public int DamageBonus { get; private set; }

        public double FuelBonus { get; private set; }
    }
}