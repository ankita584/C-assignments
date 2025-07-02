using System.Collections;

List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6 };

IQueryable<int> result1 = numbers1.AsQueryable();

IEnumerable<int> result2 = result1.AsEnumerable();

// cast
// converts non generic to generic collection

ArrayList numbers2 = new ArrayList() { 1, 2, 3, 4, 5, 6 };
IEnumerable<int> result3 = numbers2.Cast<int>();

numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6 }; // list

//int[] numbers3 = new int[numbers1.Count];
//for (int i = 0; i < numbers1.Count; i++) 
//{
//    numbers3[i] = numbers1[i]; 
//}

int[] numbers3 = numbers1.ToArray<int>(); // list to  array conversion

List<int> numbers4 = numbers3.ToList<int>(); // array to list conversion

foreach(var item in numbers4)
{
    Console.Write($"{item}\t");
}
Console.WriteLine();

Dictionary<int, int> numbers5 = numbers4.ToDictionary<int, int>(i => i);
foreach(var item in numbers5)
{
    Console.Write($"{item.Key}\t");
}
Console.WriteLine();

numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6 };

int highest = numbers1.Max();
Console.WriteLine($"highest number : {highest}");

int secondhighest = numbers1.OrderByDescending(i => i).Take(2).Skip(1).First();
Console.WriteLine($"second highest number : {secondhighest}");

int thirdhighest = numbers1.OrderByDescending(i => i).Take(3).Skip(2).First();
Console.WriteLine($"third highest number : {thirdhighest}");

Console.Read();