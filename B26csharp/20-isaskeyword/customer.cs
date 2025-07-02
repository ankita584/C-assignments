public class customer
{
    public string name { get; set; }
    public override bool Equals(object? obj)
    {
       // object => customer
          customer  c = obj as customer;
        return this.name.Equals(c?.name);
    }
}

public class silvercustomer : customer
{

}

public class student
{

}