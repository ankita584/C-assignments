//printdelegate del1 = delegate ()
//{
//    Console.WriteLine("del1 method");
//};

using System.Security.Cryptography;

printdelegate del1 = () => // lambda declaration
{
    Console.WriteLine("lambda expression 1 called");
};
del1();


//welcomedel del2 = delegate (string name)
//{
//    Console.WriteLine($"welcome : {name}");
//};

//del2("ankita");

//welcomedel del2 = (string name) => //remove()and datatype
//{
//    Console.WriteLine($"welcome, {name}");
//};
//del2("ankita");

welcomedel del2 = name => Console.WriteLine($"welcome,{name}"); //using lambda

del2("ankita");



//fullname del3 = delegate (string s1, string s2)
//{
//    return string.Format($"full name : {s1} {s2}");//s1 + " " +s2;
//};

fullnamedel del3 = (s1, s2) => string.Format($"full name : {s1} {s2}");



string fullname = del3("anika", "khade");
Console.WriteLine("fullname");

adddel del4 = (a, b) => a + b;

int add = del4();
Console.WriteLine($"addition : {add}");

Console.Read();