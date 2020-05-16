namespace PresentationExercises.OCP.Fix
{
    public class Dish : MenuItem
    {
        private decimal grams;
        private decimal pricePerGram;

        public override decimal GetPrice()
        {
            return grams * pricePerGram;
        }
    }
}