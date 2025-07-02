public class customer
{
    public int id;
    public string name;

    public string email { get; set; }

    public void print()
    {
        Console.WriteLine("print() method called");
    }
}