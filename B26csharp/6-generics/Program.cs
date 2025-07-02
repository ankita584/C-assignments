calculator c1 = new calculator();

bool isequal = c1.AreEqual(10, 10);
Console.WriteLine($" Is 10 & 10 are equal? : {isequal}");


isequal = c1.AreEqual("ankita", "anshika");
Console.WriteLine($" Is ankita & anshika are equal? : {isequal}");

isequal = c1.AreEqual("10.5f", "10.5f");
Console.WriteLine($"Is 10.5f & 10.5f are equal? ; {isequal}");

isequal = c1.AreEqual<float>(10.5f, 21.5f);
Console.WriteLine($"is 10.5f & 21.5f are equal? : {isequal}");

isequal = c1.AreEqual<char>('$', '$');
Console.WriteLine($"Is $ & $ are equal? : {isequal}");

isequal = c1.AreEqual<int>(1, 1);

Mathcalculator<int, int, int> m1 = new Mathcalculator<int, int, int>();
m1.number1 = 10;
m1.number2 = 20;
int add = m1.add();
Console.WriteLine($"result = {add}");



Console.Read();