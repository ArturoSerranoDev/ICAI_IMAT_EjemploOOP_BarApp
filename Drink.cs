public class Drink
{
    private float price;
    private int alcoholPercentage;

    // Showcasing an auto-property
    public  string Name { get; private set; } 
    
    public float Price
    {
        get
        {
            if (alcoholPercentage <= 0)
            {
                return price;
            }
            else
            {
                return price + (alcoholPercentage / 100f);
            }

            // Ternary operator example
            //return price + (alcoholPercentage <= 0 ? alcoholPercentage / 100f : 0);
        }
    }

    public int AlcoholPercentage => alcoholPercentage;

    public Drink(string name,
        float price,
        int alcoholPercentage = 0)
    {
        this.Name = name;
        this.price = price;
        this.alcoholPercentage = alcoholPercentage;
    }
}
