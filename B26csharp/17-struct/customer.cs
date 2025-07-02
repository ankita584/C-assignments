//public class customer

public struct customer
{
    public string firstname;

    public string LastName { get; set; }

    public customer(string fn, string ln)
    {
        firstname = fn;
        LastName = ln;
    }

    public void Display()
    {
        Console.WriteLine($"first name : {firstname} last name : {LastName}");
    }
}

//public class silvercustomer : customer //cannot inherit
//{

//}