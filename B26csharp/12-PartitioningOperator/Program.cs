List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

// Take
// returns number of items given to take() method
// it works very similar to top keyword SQl

//IEnumerable<int> result1 = numbers.Take(2);
IEnumerable<int> result1 = numbers.Take(4);

Console.WriteLine($"*** ALL ITEMS AFTER numbers.take(2) ***");
foreach(int i in result1)
{
    Console.Write($"{i}\t");
}
Console.WriteLine(); // new line

// Skip()
// it skips given number of items and returns rest remaining items

IEnumerable<int> result2 = numbers.Skip(2);
Console.WriteLine($"*** ALL ITEMS AFTER numbers.skip(2) ***");
foreach(int i in result2)
{
    Console.Write($"{i}");
}
Console.WriteLine();

//TakeWhile()
//it returns the item till given condition is true

//IEnumerable<int> result3 = numbers.takeWhile(i => i < 4);
//IEnumerable<int> result3 = numbers.TakeWhile(i => i > 0);

numbers = new List<int>() { 1, 2, 3, 4, 5, 6, };
IEnumerable<int> result3 = numbers.TakeWhile(i => i > 0);

// IEnumerable<int> result3 = numbers.TakeWhile(i => i % 2 == 0);

Console.WriteLine($"*** ALL ITEMS AFTER numbers.takewhile(i => i > 0 ) ***");
foreach(int i in result3)
{
    Console.Write($"{i}\t");
}
Console.WriteLine();

// SkipWhile()
// it skips the items till given condition is true
// once the condition become false it retrieves all items

numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

// IEnumerable<int> result4 = numbers.SkipWhile(i => i < 4);
// IEnumerable<int> result4 = numbers.SkipWhile(i => i % 2 == 0);


IEnumerable<int> result4 = numbers.SkipWhile(i => i % 2 != 0);
Console.WriteLine($"*** ALL ITEMS AFTER numbers.skipwhile(i => i < 4) ***");
foreach(int i in result4)
{
    Console.Write($"{i}\t");
}
Console.WriteLine();


List<int> numbers1 = new List<int>() { 1, 2, 3, };
List<int> numbers2 = new List<int>() { 1, 2, 3, };

if(numbers1.Count == numbers2.Count)
{
    numbers1.Sort();
    numbers2.Sort();
    if (numbers1.SequenceEqual(numbers2))
    {
        Console.WriteLine("numbers1 & numbers2 are EQUAL ");
    }
    else
    {
        Console.WriteLine("numbers1 & numbers2 are NOT EQUAL ");
    }
}
else
{
    Console.WriteLine("numbers1 & numbers2 are NOT EQUAL ");
}

    Console.Read();