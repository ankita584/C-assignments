// public delegate bool predicate <in T>(T obj);

Predicate<string> del1 = s => s.Length > 5;

var r1 = del1("chiv");
Console.WriteLine($"chiv : {r1}"); // false

r1 = del1("ankita");
Console.WriteLine($"ankita : {r1}"); //true

Predicate<int> del2 = i => i % 2 == 0;

r1 = del2(10);
Console.WriteLine($"10 : {r1}"); //true

r1 = del2(11);
Console.WriteLine($"11 : {r1}"); //false

// public delegate void action<in T>(T obj);

Action<string> del3 = s => Console.WriteLine($"welcome , {s}");
del3("vihan");

Action<int> del4 = i => Console.WriteLine($"you entered : {i}");
del4(20);

// public delegate void action();

Action del5 = () => Console.WriteLine("Action non generic");
del5();

// public delegate Tresult Func<out Tresult>();

Func<string> del6 = () => "HELLO";
Console.WriteLine(del6());



Console.Read();