using System.Collections.Generic;

namespace PresentationExercises.OCP.PrincipleViolation
{
public class Bill
{
    public decimal Calculate(List<object> menuItems)
    {
        decimal totalPrice = 0;

        foreach (var menuItem in menuItems)
        {
            if (menuItem is Dish)
            {
                var dish = (Dish)menuItem;
                totalPrice += dish.PricePerGram * dish.Grams;
            }

            if (menuItem is Drink)
            {
                var dish = (Drink)menuItem;
                totalPrice += dish.Price;
            }
        }

        return totalPrice;
    }
}
}