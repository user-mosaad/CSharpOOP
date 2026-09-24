namespace CSharpOOP;

// Person class
internal class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
}

// Person struct
internal struct PersonStruct
{
    public string Name;
    public int Age;
    
    public PersonStruct(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
