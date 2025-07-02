//printdelegate del1 = delegate ()
//{
//    Console.WriteLine("del1 called");
//};

printdelegate del1 = () =>
{
    Console.WriteLine("lambda expression 1 called");
};

del1();

//welcomedel del2 = (string name) =>
//{
//    Console.WriteLine($"welcome, {name}");
//};

//welcomedel del2 = (string name) =>
//{
//    Console.WriteLine($"welcome, {name}");
//};

//welcomedel del2 = (name) =>
//{
//    Console.WriteLine($"welcome, {name}");
//};

//welcomedel del2 = name =>
//{
//    Console.WriteLine($"welcome, {name}");
//};

welcomedel del2 = name => Console.WriteLine($"welcome, {name}");
del2("ankita");

//fullnamedel del3 = delegate (string s1, string s2)
//{
//    return string.Format("full name : {s1} {s2}");
//};

//fullnamedel del3 = (s1.s2) =>
//{
//    return string.Format("fullname name : {s1} {s2}");
//};


fullnamedel del3 = (s1, s2) => string.Format($"full name : {s1} {s2}");

string fullname = del3("vihan", "rathod");

// adddel del4 = (a, b) => a + b;

adddel del4 = (a, b) =>
{
    int c = a + b;  //local variable
    return c;
};

int add = del4(10, 10);
Console.WriteLine($"addition : {add}");


Console.Read();