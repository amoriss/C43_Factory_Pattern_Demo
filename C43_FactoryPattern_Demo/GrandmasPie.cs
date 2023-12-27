using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_FactoryPattern_Demo;
internal class GrandmasPie : IOrderable
{
    public double Price { get; set; }

    public void FoodDescription()
    {
        Console.WriteLine("Extra garlicly pie. Grandma's famous pie! Can't go wrong!"); ;
    }
}
