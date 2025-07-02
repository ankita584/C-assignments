List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

// All method
bool b = numbers.All(i => i > 0);
Console.WriteLine($"numbers.All(i => i > 0) : {b}"); // True

b = numbers.All(i => i > 1);
Console.WriteLine($"numbers.All(i => i > 1) : {b}"); // False

b = numbers.All(i => i % 2 == 0);
Console.WriteLine($"numbers.All(i = i % 2 == 0 : {b}"); // False

// Any method

b = numbers.Any(i => i > 0);
Console.WriteLine($"numbers.any(i => i > 0) : {b}"); // True

b = numbers.Any(i => i > 1);
Console.WriteLine($"numbers.any(i => i > 0) : {b}"); // True

b = numbers.Any(i => i % 2 == 0);
Console.WriteLine($"numbers.any(i => i % 2 == 0 )"); // True


// Contains method

b = numbers.Contains(2);
Console.WriteLine($"numbers.contains(2) : {b}"); // True

b = numbers.Contains(20);
Console.WriteLine($"numbers.contains(20) : {b}"); // False

// Contains overload

var students = student.GetAll();
Console.WriteLine("*** ALL STUDENTS ***");
foreach(var student in students)
{
    Console.WriteLine($" rollnumber : {student.rollnumber} name : {student.name} gender : {student.gender} age : {student.age}");
}

student s1 = new student() { rollnumber = 1, name = "vihan", gender = " male", age = 7 };

b = students.Contains(s1);
Console.WriteLine($"numbers.contains(20) : {b}"); // False

student s2 = new student() { rollnumber = 105, name = "guru", gender = "male", age = 20 };
b = students.Contains(s2);
Console.WriteLine($"students.contains(s2) : {b}"); // False

b = students.Contains(s2, new studenthelper());
Console.WriteLine($"students.contains(s2) : {b}"); // true

Console.Read();