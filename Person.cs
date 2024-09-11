public class Person
{
    private string name;
    private int age;

    public string Name => name;
    public int Age => age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void HaveFun()
    {
        Console.WriteLine("I'm " + name + " having fun at the bar");
    }
}