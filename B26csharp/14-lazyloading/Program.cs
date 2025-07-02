customer c = new customer();

Console.WriteLine($"customer name : {c.name}");

Console.WriteLine("ALL ORDERS");

foreach(order order in c.orders.Value)
{
    Console.WriteLine($"order id : {order.id} description : {order.description}");
}



Console.Read();
