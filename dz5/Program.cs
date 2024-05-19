namespace dz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee orderCoffee = new Espresso();
            Console.WriteLine($"Description: {orderCoffee.GetDescription()}");
            Console.WriteLine($"Cost: ${orderCoffee.GetCost()}");
        }
    }
}