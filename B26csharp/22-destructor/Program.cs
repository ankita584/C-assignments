

Console.WriteLine("program started...");

print();

Console.WriteLine("program finished...");

static void print()
{
    Console.WriteLine("print started...");

    if (true)
    {
        customer c = new customer();
    }

    Console.WriteLine("print completed");
}


Console.Read();