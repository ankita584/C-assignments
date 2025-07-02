public partial class customer : A
{
    public void print()
    {
        Console.WriteLine("print() method called");
        sample();
    }

    public partial string sample();
}

public abstract class A
{
    public abstract void printA();
}

public class B { }