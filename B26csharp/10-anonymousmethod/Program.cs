using System.Security.Cryptography;

printdelegate del = printA;

del();


//using anonymous method

printdelegate del1 = delegate ()
{
    Console.WriteLine("ANONYMOUS METHOD CALLED");
};

del1();


adddelegate add1 = delegate (int a, int b)
{
    return a + b;
};
int result = add1(10, 10);
Console.WriteLine("addition : {result}");

// examples

//printdel del = delegate (string s1, string s2)
//{
//  return  s1+ "  " + s2;
//};

//getlength del = delegate (string s) 
//{
//return string.length;
//};


printdelegate del2 = delegate ()
{
    Console.WriteLine("Anonymous method 1");
};

del2 += delegate ()
{
    Console.WriteLine("Anonymous method 2");
};

del2();




static void printA() // delegate method
{
    Console.WriteLine("printA() method called");
}




Console.Read();