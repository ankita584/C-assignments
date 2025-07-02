List<Student> students = Student.GetAll();

Console.WriteLine($"*** ALL STUDENTS ***");
foreach(Student student in students)
{
    Console.WriteLine($"rollnumber : {student.RollNumber} name : {student.Name} gender : {student.Gender} age : {student.Age}");
}
//fetch only list of students

//List<string> names = new List<string>();
//foreach(Student student in students)
//{
//    names.Add(student.Name);
//}

//projecting one single property
//var names = students.Select(s => s.Name);

var names = from s in students
            select s.Name;
foreach(string name in names)
{
    Console.Write($"{name}\t");
}
Console.WriteLine();

//projecting more than one property

//var studentshort = students.Select(s =>
//new studentshort() { name = s.Name, Gender = s.Gender });

//new studentshort = students.Select(students => new { Name = s.name, Gender = s.gender }); // using anonymous type

var studentshort = from s in students
                   select new { name = s.Name, gender = s.Gender };
foreach(var item in studentshort)
{
    Console.WriteLine($"name : {item.name} gender : {item.gender}");
}

////project all visited cities of all students
//IEnumerable<List<string>> cities = students.Select(s => s.VisitedCities);
//foreach(var city in cities)
//{
//    foreach(var c in city)
//    {
//        Console.WriteLine(city);
//    }
//}

var visitedcities = students.SelectMany(s => s.VisitedCities);
foreach(var city in visitedcities)
{
    Console.WriteLine(city);
}

Console.Read();

public class studentshort
{
    public string name { get; set; }
    public string gender { get; set; }
}