calculator c1 = new calculator();

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };


//1 2 3 4 5 6 

Console.WriteLine("*** ALL EVEN NUMBER ***");

foreach(int number in c1.GetEvenNumbers(numbers))
{
    Console.Write($"{number}\t");
}



Console.Read();