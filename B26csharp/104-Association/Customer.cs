public class order
{
    public int id { get; set; }
    public string description { get; set; }
    public int numberofproducts { get; set; }
}

public class customer
{
    public order[] orders { get; set; }
}