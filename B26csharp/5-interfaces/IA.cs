public interface IA
{
    void print();
    void printA();
    void printZ()
    {
       Console.WriteLine("common implementation");
     }
}


public interface IB
{
    void printB();
}


public class A : IA, IB
{
    public void print()
    {
        Console.WriteLine("IA print() method");
    }

    public void printA()
    {
        Console.WriteLine("IA printA() method");
}

public void printB()
    {
        Console.WriteLine(" IB PrintB () method");
    }
}

public class B : IA
{
    public void print()
    {
        Console.WriteLine("IA print()");
    }

    public void printA()
    {
        Console.WriteLine("IA printA()");
    }


    public void printZ()
    {
        Console.WriteLine("IA printZ()");
    }
}
