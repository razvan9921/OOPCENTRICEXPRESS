namespace PresentationExercises.OCP.Fix
{
    public class Drink : MenuItem
    {
        private decimal price;

        public override decimal GetPrice()
        {
            return price;
        }
    }
}