#region reverse method

//List<int> numbers = new List<int>() { 5, 1, 4, 2, 3 };

//Console.WriteLine("*** Before Reverse ***");
//foreach(var number in numbers)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

//numbers.Reverse();

//Console.WriteLine("*** After Reverse ***");
//foreach(var number in numbers)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

#endregion reverse method

#region orderby & orderbydecending

//List<int> numbers = new List<int>() { 5, 1, 4, 2, 3 };
//Console.WriteLine("*** Original Item ***");
//foreach(int number in numbers)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

//var ordered = numbers.OrderBy(i => i); // sort it in ascending order

//Console.WriteLine("*** Items After numbers.orderby(i => i) ***");
//foreach(int number in ordered)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

//ordered = numbers.OrderByDescending(i => i); // sort it in descending order

//Console.WriteLine("*** Items After numbers.orderbydescending(i => i) ***");
//foreach(int number in ordered)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

#endregion orderby & orderbydecending

#region ThenBy & ThenByDescending

//List<student> students = student.GetAll();

//Console.WriteLine("*** ALL STUDENTS ***");
//foreach (var item in students)
//{
//    Console.WriteLine($"rollnumber : {item.rollnumber} name : {item.name} gender : {item.gender} age : {item.age}");
//}

//IOrderedEnumerable<student> result1 = students.OrderBy(student => student.gender);
//foreach(var item in result1)
//{
//    Console.WriteLine($"rollnumber : {item.rollnumber} name : {item.name} gender : {item.gender} age : {item.age}");
//}

//IOrderedEnumerable<student> result2 = result1.ThenBy(s => s.age);
//Console.WriteLine($"*** ALL STUDENTS AFTER students.orderby(s => s.gender).ThenBy(s => s.age) ***");
//foreach(var item in result2)
//{
//    Console.WriteLine($"rollnumber : {item.rollnumber} name : {item.name} gender : {item.gender} age : {item.age}");

//}

//IOrderedEnumerable<student> result3 = result1.ThenByDescending(s => s.age);

//Console.WriteLine("*** ALL STUDENTS AFTER tudents.orderby(s => s.gender). ThenByDecending(s => s.age) ***");
//foreach(var item in result3)
//{
//    Console.WriteLine($"rollnumber : {item.rollnumber} name : {item.name} gender : {item.gender} age : {item.age}");
//}


#endregion ThenBy & ThenByDescending

#region sort() method

//List<int> numbers = new List<int>() { 4, 1, 5, 3, 2 };
//numbers.Sort();

//Console.WriteLine("*** numbers after sort() ***");
//foreach(int num in numbers)
//{
//    Console.Write($"{num}\t");
//}
//Console.WriteLine();

//List<string> names = new List<string>()
//{ "guru" , "avinash", "ankita", "shivani", "akansha"};

//names.Sort();
//Console.WriteLine("*** names after sort() ***");
//foreach(string item in names)
//{
//    Console.WriteLine($"{item}\t");
//}
//Console.WriteLine();

//List<student> students = student.GetAll();
//Console.WriteLine("*** ALL STUDENTS ***");
//foreach (student s in students)
//{
//    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} gender : {s.gender}  age : {s.age} ");
//}

//students.Sort();

//Console.WriteLine("*** ALL STUDENTS AFTER students.sort() ***");
//foreach (student s in students)
//{
//    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} gender : {s.gender} age : {s.age}");
//}

#endregion sort() method


#region sort() overloads

List<student> students = student.GetAll();
Console.WriteLine("*** ALL STUDENTS ***");
foreach(student s in students)
{
    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} gender : {s.gender} age : {s.age}");
}
//students.Sort();
//students.sort(new studenthelper());
//students.sort(0, 3, new studenthelper());
//public delegate int comparison<in T>(T x , T y);
//student.Sort((x, y) => x.gender.compareto(y.gender));

students.Sort((x, y) => y.gender.CompareTo(x.gender));
Console.WriteLine("*** ALL STUDENTS AFTER students.sort() ***");
foreach(student s in students)
{
    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} gender : {s.gender} age : {s.age}");
}
#endregion sort() overloads

Console.Read();