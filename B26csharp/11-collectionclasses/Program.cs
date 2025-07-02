#region arraylist

//using System.Collections;


//ArrayList number = new ArrayList();

//number.Add(10);
//number.Add(20);
//number.Add(30);

//Console.WriteLine($"Numbers of items : {number.Count}");
//Console.WriteLine("**** Items in arraylist ****");
//foreach(int i in number)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine(); //new line


//number.Add(40);

//Console.WriteLine($"**** Items in arraylist after number add(40) ");
//foreach(int i in number)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine(); // new line

//ArrayList temp = new ArrayList() { 50, 60};
//number.AddRange(temp);

//Console.WriteLine($"**** Items in arraylist after number .addrange(temp) ****");
//foreach(int i in number)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine(); //new line

//// 10 20 30 40 50 60

//number.Insert(0, 5);

//Console.WriteLine($"**** Items in arraylist after number insert(0, 5) ****");
//foreach(int i in number)
//{
//    Console.Write($"{i} ");      // 5 10 20 30 40 50 60 
//}
//Console.WriteLine();  // new line

//ICollection temp1 = new ArrayList() { 6, 7, 8 };
//number.InsertRange(1, temp1);

//Console.WriteLine("**** Items in arraylist after number.insertrange(6, 7, 8) ****");
//foreach(int i in number)
//{
//    Console.Write($"{i} "); // 5 6 7 8 10 20 30 40 50 60
//}
//Console.WriteLine();

//number.RemoveAt(5);

//Console.WriteLine($"**** Items in arraylist after number.removeat (5) ****");
//foreach (int i in number)
//{
//    Console.Write($"{i} "); // 6 7 8 9 10 30 40 50 60
//}
//Console.WriteLine();

//number.Remove(8);
//Console.WriteLine($"**** Items in arraylist after number.remove(8) ****");
//foreach(int i in number)
//{
//    Console.Write($"{i} "); // 5 6 7 10 20 30 40 50 60 
//}
//Console.WriteLine();

//number.RemoveRange(0, 3);
//Console.WriteLine($"**** Items in arraylist after number.removerange(0, 3) ****");
//foreach(int i in number)
//{
//    Console.Write($"{i} "); // 10 20 30 40 50 60
//}
//Console.WriteLine();

//number.Clear();
//Console.WriteLine("**** Items in arraylist after number.clear() ****");
//Console.WriteLine($"Number of items : {number.Count}");  // 0

//number = new ArrayList() { 10, 20, 30 };
//ArrayList number1 = new ArrayList(number);

//Console.WriteLine($"Items in number1 : {number1.Count}");

//ArrayList number2 = new ArrayList(10); //capacity


//Console.Read();

#endregion arraylist

#region Hashtable

//using System.Collections;

//Hashtable students = new Hashtable();
//students.Add(1, "ankita");
//students.Add(2, "bharti");
//students.Add(3, "avinash");

//Console.WriteLine($"Number of items : {students.Count}");

//Console.WriteLine("**** All Students ****");
//foreach (DictionaryEntry student in students)
//{
//    Console.WriteLine($"key : {student.Key} value : {student.Value}");
//}
//if(!students.ContainsKey(4))
//{
//    students.Add(4, "pruthwi");
//}
//else
//{
//    Console.WriteLine("students collections already conytains a key 4");
//}

//Console.WriteLine($"Number of items : {students.Count}");

//Console.WriteLine("**** All Students add (3, \"pruthwi\") ****");
//foreach(DictionaryEntry student in students)
//{
//    Console.WriteLine($"key : {student.Key} value : {student.Value}");
//}

//// lookup

//var val = students[2];
//Console.WriteLine($"key : 2 value : {val}");

//students.Remove(4);
//Console.WriteLine($"Number of items : {students.Count}");
//foreach(DictionaryEntry student in students)
//{
//    Console.WriteLine($"key : {student.Key} value : {student.Value}");
//}


//    Console.Read();

#endregion Hashtable

#region Stack

//using System.Collections;

//Stack history = new Stack();

//history.Push("www.google.com");
//history.Push("www.google.com/search/c#");
//history.Push("www.csharpcorner.com");

//Console.WriteLine($"Number of sites ; {history.Count}");

////var site = history.Pop();  //returns & removes last added item in stack
//var site = history.Peek(); // returns last item without removing it

//Console.WriteLine($"pop() : {site}");  // www.csharpcorner.com

//Console.WriteLine($"Number of sites : {history.Count}");

////foreach //not possible to iterate


//Console.Read();

#endregion Stack


#region queue
//using System.Collections;

//Queue row = new Queue();

//row.Enqueue("ankita");
//row.Enqueue("shivani");
//row.Enqueue("anshika");

//Console.WriteLine($"number in rows : {row.Count}"); //3

//var person = row.Dequeue(); // return first added item and removes it
//Console.WriteLine($"row.Dequeue() : {person}");

//Console.WriteLine($"number in rows : {row.Count}"); // 2

//person = row.Peek();

//Console.WriteLine($"row.peek() : {person}"); // shivani

//Console.WriteLine($"number in rows : {row.Count}"); //2
 



//Console.Read();

//#endregion queue