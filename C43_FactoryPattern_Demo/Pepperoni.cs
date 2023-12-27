using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_FactoryPattern_Demo;
internal class Pepperoni : IOrderable
{
    public double Price { get; set; } = 12.50;

    public void FoodDescription()
    {
        Console.WriteLine("The classic Pepperoni Supremo is a fan favorite.");
    }
}
