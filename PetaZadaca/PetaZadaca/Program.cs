using static PetaZadaca.Decorater;

public class Program
{
    public static void Main(string[] args)
    {
        Coffee myCoffee = new Espresso();
        Console.WriteLine($"{myCoffee.GetDescription()} costs {myCoffee.GetCost()}");

        myCoffee = new Milk(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} costs {myCoffee.GetCost()}");

        myCoffee = new Sugar(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} costs {myCoffee.GetCost()}");
    }
}
