namespace CSharpOOP;

public class A
{
    public virtual void DoWork() { Console.WriteLine("Class A Work"); }
}
public class B : A
{
    public override void DoWork() { Console.WriteLine("Class B Work"); }
}

public class C : B
{
    public sealed override void DoWork() { Console.WriteLine("Class C Work"); }
}

public class D : C
{
    public new void DoWork() { Console.WriteLine("Class D Work"); }
}
