namespace C43_FactoryPattern_Demo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What kind of pizza would you like");
        string userInput = Console.ReadLine();

        IOrderable customerOrder = FoodFactory.OrderFood(userInput);

        customerOrder.FoodDescription();
        Console.WriteLine($"Price of Pie: ${customerOrder.Price}");
    }
}
