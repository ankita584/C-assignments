customer c = new customer();

customer c2 = new customer();

silvercustomer c3 = (silvercustomer)c2;

customer c4 = null;

silvercustomer c5 = (silvercustomer)c4;

object o1 = new student();
silvercustomer c8 = (silvercustomer)o1;

//silvercustomer c8 = o1 as silvercustomer; // returns null

if(c8 == null)
{
    Console.WriteLine("unable to cast student to silvercustomer");
}
else
{
    Console.WriteLine("conversion success");
}

if(o1 is silvercustomer)
{
    Console.WriteLine($"o1 is type of silver customer");
}
else
{
    Console.WriteLine($"o1 is not type of silver customer");
}

Console.WriteLine("Main Ends...");

    Console.Read();