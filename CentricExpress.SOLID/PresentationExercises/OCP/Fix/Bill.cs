using System.Collections.Generic;

namespace PresentationExercises.OCP.Fix
{
public class Bill
{
    public decimal Calculate(List<MenuItem> menuItems)
    {
        decimal totalPrice = 0;

        foreach (var menuItem in menuItems)
        {
            totalPrice += menuItem.GetPrice();
        }

        return totalPrice;
    }
}
}