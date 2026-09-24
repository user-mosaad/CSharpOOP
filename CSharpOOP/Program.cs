using CSharpOOP.Shapes;

namespace CSharpOOP;

class Program
{
    static void Main()
    {
        // Person class 
        Person p1 = new("John", 32);
        Person p2 = new("Thomas", 34);
        Person p3 = p1;
        Console.WriteLine(ReferenceEquals(p1, p2)); // False
        Console.WriteLine(ReferenceEquals(p1, p3)); // True

        Console.WriteLine();

        // Person struct
        PersonStruct ps1 = new PersonStruct("Michael", 33);
        PersonStruct ps2 = new("Arthur", 35);
        PersonStruct ps3 = new("Arthur", 35);
        Console.WriteLine(Equals(ps2, ps3)); // True
        Console.WriteLine(ps1.Equals(ps2)); // False

        Console.WriteLine();

        // Working with the Shape classes
        List<Shape> shapes =
        [
            new Rectangle(),
            new Triangle(),
            new Circle()
        ];

        foreach (var shape in shapes)
        {
            shape.Draw();
        }

        Console.WriteLine();

        // NewMembersTest
        DerivedClass B = new();
        B.DoWork(); // Calls the new method

        BaseClass A = (BaseClass)B;
        A.DoWork(); // Calls the old method

        // SealedOverrideTest
        D d = new();
        d.DoWork();

        C c_d = d;
        c_d.DoWork();

        B b_d = d;
        b_d.DoWork(); // Uses class C's overriden method

        A a_d = d;
        a_d.DoWork(); // Uses class C's overriden method
    }
}
