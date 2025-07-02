public class order
{
    public int id { get; set; }
    public string description { get; set; }
}


public class customer 
{
    public string name { get; set; }

    //public lazy<list<order>>orders {get; set;}

    public Lazy<List<order>> orders { get; set; }

    public customer()
    {
        name = "ankita";
        //orders = GetOrders();
        //Orders = new lazy<list<order>>(delegate()
        //{
        //return GetOrders();
        //});


        orders = new Lazy<List<order>>(() => GetOrders());
    }
    public List<order>GetOrders()
    {
        // in reality these order details will come from database

        return new List<order>()
        {
            new order(){id = 1, description = "order 1"},
            new order(){id = 2, description = "order 2"},
            new order(){id = 3, description = "order 3"},
        };
    }
}
    

    