using System;

List<student> students = new List<student>()
{
    new student(){rollnumber = 1, name = "ankita", age = 25},
    new student(){rollnumber = 2, name = "bharti", age = 18},
    new student(){rollnumber = 3, name = "shivani", age = 16},
    new student(){rollnumber = 4, name = "anvi", age = 22},
    new student(){rollnumber = 5, name = "gokul", age = 20},

};

Console.WriteLine("*** All Student ***");
foreach(var student in students)
{
    Console.WriteLine($"rollnumber : {student.rollnumber}, name : {student.name}, age : {student.age} ");
}

//find all students whose age between 15 & 20

#region without linq

//List<student> students1 = new List<student>();
//foreach(var student in students1)
//{
//    if(student.age >= 15 && student.age <= 20)
//    {
//        students1.Add(student);
//    }
//}

//Console.WriteLine($" All Students between 15 & 20 age");
//foreach(var s in students1)
//{
//    Console.WriteLine($"rollnumber : {s.rollnumber}, name : {s.name}, age : {s.age}");
//}


#endregion without linq

#region with linq method syntax

//List<student> students1 = new List<student>();
//foreach (var student in students1)
//{

//    if (student.age >= 15 && student.age <= 20)
//    {
//        students1.Add(student);
//    }
//}

//using linq//
// var or IEnumerable<student>

//var students1 = students.Where(s => s.age >= 15 && s.age <= 20);

//Console.WriteLine($" All Students between 15 & 20 age");
//foreach (var s in students1)
//{
//    Console.WriteLine($"rollnumber : {s.rollnumber}, name : {s.name}, age : {s.age}");
//}

#endregion without linq method syntax

#region with linq query syntax

//var students1 = students.Where(s => s.age >= 15 && s.age <= 20);

IEnumerable<student> students1 = from s in students
                                 where s.age >= 15 && s.age <= 20
                                 select s;

Console.WriteLine($" All Students between 15 & 20 age");
foreach (var s in students1)
{
    Console.WriteLine($"rollnumber : {s.rollnumber}, name : {s.name}, age : {s.age}");
}


#endregion with linq query syntax



Console.Read();