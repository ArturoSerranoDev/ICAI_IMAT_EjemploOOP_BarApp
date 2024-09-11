public class Client : Person
{
    private Drink drink;

    public Client(string name, int age, Drink drink) : base(name, age)
    {
        this.drink = drink;
    }

    public override void HaveFun()
    {
        base.HaveFun();

        Drink();
    }

    public void Drink()
    {
        Console.WriteLine("Drinking my " + drink.Name);
    }

    public float Pay()
    {
        Console.WriteLine("Let me pay you " + drink.Price);
        return drink.Price;
    }
}


