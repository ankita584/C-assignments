public class customer
{
    public void PrintA()
    {
        Console.WriteLine("void printA() called");
    }

    public static void printB()
    {
        Console.WriteLine("static void printB() called");
    }

    public void printC(string name)
    {
        Console.WriteLine($"void printC(string {name}) called)");
    }

    public string printD()
    {
        return "string printD() method called";
    }
    private void printE()
    {
        Console.WriteLine("private void printA() called");
    }
}