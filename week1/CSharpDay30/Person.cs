public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static bool IsAdult(int age)
    {
        return age >= 18;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}