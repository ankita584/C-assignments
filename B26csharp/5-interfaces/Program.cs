Icustomer c1 = new silvercustomer();
c1.printticket();
Console.WriteLine($"silver ticket amount : {c1.getticketamount()}");

c1 = new goldcustomer();
c1.printticket();
Console.WriteLine($"gold ticket amount : {c1.getticketamount()}");

IA a1 = new A();
a1.printA();

IB b1 = new A();
b1.printB();

IA a = new A();
a.print();

Console.Read();