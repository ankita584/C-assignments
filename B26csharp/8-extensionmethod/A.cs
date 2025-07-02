

public class A : IA
{

}

public class B : IB
{

}

public interface IA { }

public static class helperclass
{
    //    public static void print(this A a)
    //    {
    //        Console.WriteLine($"type name : {a.GetType().Name}");
    //    }

    //    public static void print(this B b)
    //    {
    //        Console.WriteLine($"type name : {b.GetType().Name}");
    //    }
    //}

    public static void print(this IA a)
    {
        Console.WriteLine($"Type Name : {a.GetType().Name}");

    }
}