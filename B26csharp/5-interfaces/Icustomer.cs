public interface Icustomer
{
    void printticket(); //deafault access specifier public

     int getticketamount();
}
public class silvercustomer : Icustomer
{
    public void printticket()
    {
        Console.WriteLine("silver ticket printed");
    }
     public int getticketamount()
    {
        return 150;
    }
}

public class goldcustomer : Icustomer
{
    public int getticketamount()
    {
        return 300;
    }

    public void printticket()
    {
        Console.WriteLine("gold ticket printed");
    }
}