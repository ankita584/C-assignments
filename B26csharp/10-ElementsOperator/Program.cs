List<int> numbers = new List<int>()
{ 10, 20, 30, 40, 50, 60 };

#region ElementAt() method

//ElementAt
//returns element at given index
//throws exception when given index is out of range

//int item = numbers.ElementAt(2);
//Console.WriteLine($"numbers.elementat(2) : {item}");  // 30

//item = numbers.ElementAt(5);
//Console.WriteLine($"numbers.elementat(5) : {item}"); // 60

//item = numbers.ElementAt(11); // throws exception
//Console.WriteLine($"number.elementat(11) : {item}");

////ElementAtOrDefault
////returns element at given index
////handles exception and return default value when given index is out of range
//item = numbers.ElementAtOrDefault(5);
//Console.WriteLine($"numbers.elementatordefault(5) : {item}"); // 60

//item = numbers.ElementAtOrDefault(11);
//Console.WriteLine($"numbers.elementatordefault(11) : {item}"); // 0

#endregion ElementAt() method

#region First() Method

//first()
//return first matching item
//even if there are multiple matching items returns first matching item

//int item = numbers.First();
//Console.WriteLine($"numbers.first() : {item}"); // 10

//item = numbers.First(i => i > 15);
//Console.WriteLine($"numbers.first(i => i > 15) : {item}"); // 10

//item = numbers.First(i => i > 150);
//Console.WriteLine($"numbers.first(i => i > 150) : {item}"); // throws exception

////firstordefault
//// returns first matching item
//// even if there are multiple matching items returns first matching item
//// if there is not matching item FirstOrDefault() handles exception and returns default value
///

//item = numbers.FirstOrDefault(i => i > 150); // handels exception
//Console.WriteLine($"numbers.FirstOrDefault(i => i > 150) : {item}"); // 0


#endregion First() Method

#region Last() Method

//// Last() Method
//// returns last matching item from given collection
//// even if there are multiple matching item it returns last matching item
//// if there is no matching item found for given condition throws exception


//int item = numbers.Last();
//Console.WriteLine($"numbers.last() : {item}"); // 60

//item = numbers.Last(i => i > 15);
//Console.WriteLine($"numbers.Last(i => i > 15) : {item}"); // 60

//item = numbers.Last(i => i < 20);
//Console.WriteLine($"numbers.Last(i => i < 20) : {item}"); // 10

//item = numbers.Last(i => i > 100); // throws exception
//Console.WriteLine($"numbers.Last(i => i > 100) : { item}");

//// LastOrDefault() Method
//// returns last matching item from given collection
//// even if there are multiple matching item it returns last matching item
//// if there is no matching item found for given condition handles exception and returns default value

//item = numbers.LastOrDefault(i => i > 100);  // handels exception
//Console.WriteLine($"numbers.Lastordefault(i => i > 100) : {item}"); // 0

#endregion Last() Method

#region Single() Method

// Single()
// returns first matching item from given collection
// Single() method throws exception
// 1. if there are no matching item found for given condition
// 2. if there are multiple matching item found for given condition

int item = numbers.Single(i => i > 50);
Console.WriteLine($"numbers.Single(i => i > 50) : {item}"); // 60

item = numbers.Single(i => i < 15);
Console.WriteLine($"numbers.Single(i => i < 15) : {item}"); // 10

//item = numbers.Single(i => i < 5);
//Console.WriteLine($"numbers.single(i => i < 5) : {item}"); // exception

// SingleOrDefault()
// returns first matching item from given collection
// 1. if there are no matching item found for given condition it handles exception and returns default value
// 2. if there are multiple matching item found for given condition it also throws exception

item = numbers.SingleOrDefault(i => i < 5);
Console.WriteLine($"numbers.SingleOrDefault(i => i < 5) : {item}"); // 0

//item = numbers.SingleOrDefault(i => i > 20); // throws exception
//Console.WriteLine($"numbers.SingleOrDefault(i => i > 20) : {item}"); 



#endregion Single() Method


Console.Read();