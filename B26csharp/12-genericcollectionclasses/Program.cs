#region list<>
//using System;
//using System.Collections.Generic;

//List<int> numbers = new List<int>();

//numbers.Add(10);
//numbers.Add(20);
//numbers.Add(30);

//Console.WriteLine($"Number of item : {numbers.Count}"); // 3

//Console.WriteLine($"**** ALL STUDENTS ****");
//foreach(int i in numbers)
//{
//    Console.Write($"{i}\t");
//}
//Console.WriteLine(); //new line

//numbers.AddRange(new List<int>() { 40, 50, 60 });

//Console.WriteLine($"**** ALL NUMBERS AFTER AddRange(new List<int>() {{ 40, 50, 60 }}); ****");
//foreach(int i in numbers)
//{
//    Console.Write($"{i}\t"); // 10 20 30 40 50 60
//}
//Console.WriteLine(); // new line

//numbers.Insert(1, 15); 
//Console.WriteLine($"**** ALL NUMBERS AFTER numbers.insert (1, 15) ****");
//foreach(int i in numbers)
//{
//    Console.Write($"{i}\t");  // 10 15 20 30 40 50 60
//}
//Console.WriteLine();

//numbers.RemoveAt(1);
//Console.WriteLine($"**** ALL NUMBERS AFTER number.removeat(1) ****");
//foreach(int i in numbers)
//{
//    Console.Write($"{i}\t");  // 10 20 30 40 50 60 
//}
//Console.WriteLine(); //new line

//numbers.Remove(60);
//Console.WriteLine($"**** ALL NUMBERS AFTER numbers.remove(60) ****");
//foreach(int i in numbers)
//{
//    Console.Write($"{i}\t"); // 10 20 30 40 50
//}
//Console.WriteLine();

//numbers.RemoveAll(i => i > 30);
//Console.WriteLine($"**** ALL NUMBERS AFTER numbers.removeall(i => i > 30) ****");
//foreach(int i in numbers)
//{
//    Console.Write($"{i}\t"); // 10 20 30
//}
//Console.WriteLine();

//numbers.RemoveRange(1, 2);

//Console.WriteLine($"*** ALL NUMBERS AFTER numbers.RemoveRange(1, 2) ***");
//foreach (int i in numbers)
//{
//    Console.Write($"{i}\t"); ///// 10
//}
//Console.WriteLine(); // new line


//numbers.RemoveAt(0);
//numbers.Insert(0, 5);

//Console.WriteLine($"*** ALL NUMBERS AFTER numbers.RemoveRange(1, 2) ***");
//foreach (int i in numbers)
//{
//   Console.Write($"{i}\t"); ///// 5
//}
//Console.WriteLine(); // new line


//Console.Read();


#endregion list<>

#region Dictionary<>

//Dictionary<int, string> students =
//    new Dictionary<int, string>();

//students.Add(1, "ajinkya");
//students.Add(2, "bharti");
//students.Add(3, "ankita");

//Console.WriteLine($"Number of items : {students.Count}");

//// foreach (var student in students)
//// foreach (object student in students) // not possible as we dont get Kye & Value property To achive it we need to do type casting
//// foreach (dynamic student in students)
//foreach (KeyValuePair<int, string> student in students)
//{
//    Console.WriteLine($"Key : {student.Key} Value : {student.Value}");
//}

//bool b1 = students.ContainsKey(1);
//Console.WriteLine($"Key 1 exists ? {b1}");

//b1 = students.ContainsValue("sunita");
//Console.WriteLine($"Is sunita value exists ? {b1}");

//string name = students[2];
//Console.WriteLine($"students[2] : {name}");


//Console.Read();





#endregion dictionary<>

#region stack<>

//using System.Collections.Generic;

//Stack<string> names = new Stack<string>();

//names.Push("arpitha");
//names.Push("pranav");
//names.Push("narendra");

//Console.WriteLine($"Number of items : {names.Count}"); // 3

//string name = names.Pop();
//Console.WriteLine($"names.Pop() : {name}"); // narendra

//Console.WriteLine($"Number of items : {names.Count}"); // 2

//name = names.Peek();
//Console.WriteLine($"names.Peek() : {name}"); // narendra

//Console.WriteLine($"Number of items : {names.Count}"); // 2

//Console.Read();



#endregion stack<>

#region queue<>

using System.Collections.Generic;
using System.Data;

Queue<string> row = new Queue<string>();

row.Enqueue("anvi");
row.Enqueue("guru");
row.Enqueue("nirvi");

Console.WriteLine($"Number of item : {row.Count}");  // 3

string name = row.Dequeue();
Console.WriteLine($"row.dequeue() : {name}");

Console.WriteLine($"Number of item : {row.Count}"); // 2

name = row.Peek();
Console.WriteLine($"row.peek() : {name}");

Console.WriteLine($"Number of item : {row.Count}"); //2

name = row.Peek();
Console.WriteLine($"row.peek() : {name}");
Console.WriteLine($"Number of item : {row.Count}"); 

Console.Read();
#endregion queue<>