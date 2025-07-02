partial class customer
{
    public int id { get; set;}

    public override void printA()
    {
        throw new NotImplementedException();
    }

    public partial string sample()
    {
        Console.WriteLine("partial sample() method");
        return "sample method";
    }
}