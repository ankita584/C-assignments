//customer c1 = new customer() { firstname = "ankita", lastname = "khade" };
customer c1 = new customer("ankita", "khade");
Console.WriteLine($"c1 : first name : {c1.firstname} last name : {c1.lastname}");

//c1.firstname = "pari"; // mutabale

Console.WriteLine($"c1 : first name : {c1.firstname} last name : {c1.lastname}");

//customer c2 = c1;
//customer c2 = new customer() { firstname = "ankita", lastname = "khade" };
customer c2 = new customer("ankita", "khade");

if(c1.Equals(c2))
{
    Console.WriteLine("c1 & c2 are EQUAL");
}
else
{
    Console.WriteLine("c1 & c2 are NOT EQUAL");
}

customer c3 = c2;
Console.WriteLine($"firstname : {c3.firstname} lastname : {c3.lastname}");

customer c4 = c3 with { firstname = "pari" };
Console.WriteLine($"c4 : firstname : {c4.firstname} lastname : {c4.lastname}");

    Console.Read();