public class employee
{
    public int id { get; set; }
    public string name { get; set; }
       
    public department department { get; set; }
}

public class department
{
    public string name { get; set; }

    public employee[] employees { get; set; }
}