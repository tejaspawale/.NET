namespace User;

public class Person
{
    public string Name {get;set;}

    public string SetName(string name)
    {
        return this.Name = name;
    }

    public int Age {get; set;}

    public Person(string n, int a)
    {
        Name = n;
        Age = a;
    }

    
}