public class Bar
{
    private List<Drink> availableDrinks = new List<Drink>();
    private List<Person> peopleAtBar = new List<Person>();

    private const int MIN_AGE_TO_BE_SERVED = 3;
    private const int MIN_AGE_TO_DRINK_ALCOHOL = 18;

    private float moneyEarned = 0f;

    public Bar(List<Drink> drinksByProvider, List<Person> people)
    {
        availableDrinks = drinksByProvider;
        peopleAtBar = people;
    }

    public void StartApp()
    {
        // Serve clients
        for (int i = 0; i < peopleAtBar.Count; i++)
        {
            Person person = peopleAtBar[i];

            Console.WriteLine(person.Name + " enters by the front door");

            // Ignore babies
            if (person.Age < MIN_AGE_TO_BE_SERVED)
            {
                Console.WriteLine("What a cute baby, let me serve your parents");
                continue;
            }

            Console.WriteLine("What do you want?");

            // Read input
            string clientPetition = Console.ReadLine();

            // try to get drink
            Drink selectedDrink = GetDrink(clientPetition);

            if (selectedDrink == null)
            {
                Console.WriteLine("I'm sorry, I don't have what you asked for");
                continue;
            }

            // Do not serve alcohol to minors
            if (selectedDrink.AlcoholPercentage > 0 &&
                !CanDrinkAlcohol(person))
            {
                Console.WriteLine("Sorry child, cannot serve you alcohol");
                continue;
            }

            // Transform person to client
            peopleAtBar[i] = new Client(person.Name, person.Age, selectedDrink);
        }

        // Let clients have fun
        for (int i = 0; i < peopleAtBar.Count; i++)
        {
            Person person = peopleAtBar[i];
            person.HaveFun();

            if (person is Client client)
            {
                moneyEarned += client.Pay();
            }
        }

        Console.WriteLine("What a good day, I've earned " + moneyEarned);
    }

    private Drink GetDrink(string clientPetition)
    {
        for (int i = 0; i < availableDrinks.Count; i++)
        {
            var drink = availableDrinks[i];

            if (drink.Name == clientPetition)
            {
                availableDrinks.Remove(drink);
                return drink;
                //return new Drink(drink.name, drink.liquidAmount, drink.alcoholPercentage);
            }
        }

        return null;
    }

    private bool CanDrinkAlcohol(Person person)
    {
        return person.Age > MIN_AGE_TO_DRINK_ALCOHOL;
    }
}
