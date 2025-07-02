List<int> numbers = new List<int>() { 4, 6, 1, 3, 2, 5 };

#region highest number without linq

//int highest = 0;
//foreach(int number in numbers)
//{
//    if(number > highest)
//    {
//        highest = number;
//    }
//}
//Console.WriteLine($"highest number is {highest}");

//int minimum = highest;
//foreach(int number in numbers)
//{
//    if (number < minimum)
//    {
//        minimum = number;
//    }
//}
//Console.WriteLine($"lowest number is {minimum}");

#endregion highest number without linq


int max = numbers.Max();
Console.WriteLine($"numbers.max() : {max}");

int min = numbers.Min();
Console.WriteLine($"numbers.min() : {min}");

double average = numbers.Average();
Console.WriteLine($"numbers.average : {average}");

int sum = numbers.Sum();
Console.WriteLine($"numbers.sum : {sum}");

int count = numbers.Count();
Console.WriteLine($"numbers.count : {count}");

long longcount = numbers.LongCount();
Console.WriteLine($"numbers.longcount");

int aggregate = numbers.Aggregate((x, y) => x + y);
Console.WriteLine($"numbers.aggregate((x, y) => x + y) : {aggregate}"); //21

List<string> names = new List<string>() { "bharti", "ankita", "prajakta", "ajinkya", "hanumant" };

string all = names.Aggregate((s1, s2) => s1 + "," + s2);

var students = Student.GetAll();

int minage = students.Min(s => s.Age);
Console.WriteLine($"minimum student age : {minage}");


Console.Read();