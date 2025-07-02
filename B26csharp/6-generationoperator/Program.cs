List<int> numbers1 = null;

List<int> numbers2 = new List<int>();
Console.WriteLine($"numbers of item in numbers2 collection : {numbers2.Count}"); // 0

IEnumerable<int> numbers3 = numbers2.DefaultIfEmpty();
Console.WriteLine($"numbers of items in numbers3 collection : {numbers3.Count()}"); // 1

IEnumerable<int> numbers4 = Enumerable.Empty<int>();
Console.WriteLine($"numbers of items in numbers4 collection : {numbers4.Count()}");

IEnumerable<int> numbers5 = Enumerable.Repeat<int>(1, 10);
Console.WriteLine($"number of items in number5 collection : {numbers5.Count()}");
foreach(var num in numbers5)
{
    Console.Write($"{num}\t");
}
Console.WriteLine();

IEnumerable<int> numbers6 = Enumerable.Range(1, 20);
Console.WriteLine($"number of items in numbers6 collection : {numbers6.Count()}");
foreach(var num in numbers6)
{
    Console.Write($"{num}\t");
}
Console.WriteLine();

IEnumerable<string> name = Enumerable.Repeat<string>("ankita", 10);


Console.Read();