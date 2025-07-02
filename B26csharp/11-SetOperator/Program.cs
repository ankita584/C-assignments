List<string> names = new List<string>()
{ "ankita", "anvi", "shivani", "anvi", "anshika"};

//distinct method()

var result = names.Distinct();
Console.WriteLine($"*** ALL NAMES AFTER names.distinct() ***");
foreach (var name in result) 
{
    Console.Write($"{name}\t");
}
Console.WriteLine();

List<string> batch25 = new List<string>() { "guru", "lokesh", "rakesh", "vijaya" };
List<string> batch26 = new List<string>() { "ankita", "anshika", "guru", "vijaya" };

//concat()
// it concatinate all items from second collection with all items from first collection
// it works like union all in sql
// it does not ignore duplicates
// we use this method to merge two or more than two collections

var result1 = batch25.Concat(batch26);
Console.WriteLine($"*** batch25.concat(batch26) ***");
foreach(var name in result1)
{
    Console.Write($"{name}\t");
}
Console.WriteLine();

// Union()
// it concatinate all items from second collection with all items from first collection
// it works like union in sql
// it ignore duplicates
// we use this method to merge two or more than two collections by ignoring duplicate items

var result2 = batch25.Union(batch26);
Console.WriteLine($"($\"*** batch25.union(batch26) ***");
foreach(var name in result2)
{
    Console.Write($"{name}\t");
}
Console.WriteLine();

var result3 = batch25.Except(batch26);
Console.WriteLine($"*** batch25.Except(batch26) ***"); 
foreach(var name in result3)
{
    Console.Write($"{name}\t");
}
Console.WriteLine();

var result4 = batch25.Intersect(batch26);
Console.WriteLine($"*** batch25.Intersect(batch26) ***");
foreach(var name in result4)
{
    Console.Write($"{name}\t");
}
Console.WriteLine();

Console.Read();