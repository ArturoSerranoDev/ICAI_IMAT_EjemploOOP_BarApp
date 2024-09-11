using System;

class Program
{
    static void Main(string[] args)
    {
        // Build
        Drink fanta = new Drink("fanta", 1.5f);
        Drink cocacola = new Drink("cocacola", 1.5f);
        Drink barcelo = new Drink("barcelo", 1.5f, alcoholPercentage: 40);

        Person Carlos = new Person("Carlos", 15);
        Person Maria = new Person("Maria", 33);
        Person Juan = new Person("Juan", 2);

        Bar barICAI = new Bar(new List<Drink>() { fanta, cocacola, barcelo }, 
            new List<Person>() {Juan, Carlos, Maria });

        // Start
        barICAI.StartApp();
    }
}

