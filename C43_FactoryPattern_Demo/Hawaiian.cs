using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_FactoryPattern_Demo;
internal class Hawaiian : IOrderable
{
    public double Price { get; set; }

    public void FoodDescription()
    {
        Console.WriteLine("The most contraversial pizza of all time. But with a twist with our famous Hawaiian drizzle.");
    }
}
