using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_FactoryPattern_Demo;
internal class FoodFactory
{

    public static IOrderable OrderFood(string choice)
    {
        switch (choice)
        {
            case "pepperoni":
                return new Pepperoni();
            case "hawaiian":
                return new Hawaiian();
            case "grandma's pie":
                    return new GrandmasPie();
            default:
                return new Pepperoni();
        }
    }
}
