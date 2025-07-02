public delegate void PrintDelegate();  //delegate declaration//internal access specifire



public class calculator
{
    public void printA()
    {
        Console.WriteLine("printA() method called");
    }

    public void PrintB(printdelegate print)
    {
        print(); //calling or invoke delegate
    }

    public void printC()
    {
        Console.WriteLine("printC() method called");
    }
        
        
}