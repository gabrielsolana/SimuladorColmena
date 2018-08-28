namespace SimuladorColmena
{
    public class Bee
    {
        public const double HoneyUnitsConsumedPerMg = 0.25;

        public double Weight { get; set; }

        public Bee(double weight)
        {
            Weight = weight;
        }

        public double HoneyConsumptionRate()
        {
            return Weight * HoneyUnitsConsumedPerMg;
        }

    }
}