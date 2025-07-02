#region using calculator class

//calculator c1 = new calculator();

//// delegate instance
//printdelegate pd = new printdelegate(c1.printA);

//c1.PrintB(pd);


//printdelegate pd1 = new printdelegate(c1.printC);
//pd1();

#endregion using calculator class

#region single cast delegate

//// 2nd creating delegate instance
//printdel del = new printdel(printA); //method

//// 3rd delegate call
//del();


////printA(); //method call

////anpther way to create delegate instance
//printdel del1 = printA;

//del1();  // it will call printA() method

//static void printA()
//{
//    Console.WriteLine("printA() method called");
//}
#endregion single cast delegate

#region multi cast delegate

//printdel del1 = print1;
//printdel del2 = print2;
//printdel del3 = print3;

//printdel del = del1 + del2 + del3; // del is multi cast delegate

//del();

//printdel del = print1;
//del += print2;
//del += print3;
//del -=print2;

//del();

////static void print1()
//{
//    Console.WriteLine("print1() method called");
//}

////static void print2()
//{
//    Console.WriteLine("print2() method called");
//}

//static void print3()
//{
//   Console.WriteLine("print3() method called");
//}

#endregion multi cast delegate

#region multi cast delegate scenario


printdelegate del = printA;
del += printB;
del += printC;

//string result = del();
//Console.WriteLine(result);


Delegate[] all = del.GetInvocationList();

foreach (Delegate d in all)
{
    string result = d.DynamicInvoke().ToString();
    Console.WriteLine(result);
}


static string printA()
{
    return "A";
}

static string printB()
{
    return "B";
}

static string printC()
{
    return "C";
}




#endregion multi cast delegate scenario



Console.Read();

// 1st delegate declaration

public delegate void printdel();

public delegate string printdelegate();

