var students = student.GetAll();

Console.WriteLine("*** ALL STUDENTS ***");
foreach(student student in students)
{
    Console.WriteLine($"rollnumber : {student.rollnumber} name : {student.name} gender : {student.gender} age : {student.age}");
}

//IEnumerable<IGrouping<string,student>> groups = students.GroupBy(s => s.gender );
//IEnumerable<IGrouping<string, student>> groups = from s in students
                                                 //group s by s.gender;       //query syntax

IEnumerable<IGrouping<string, student>> groups = students.ToLookup(s => s.gender);

foreach(var group in groups)
{
    Console.WriteLine($"group name : {group.Key} number of items : {group.Count()}");
    
        foreach(var item in group)
        {
        Console.WriteLine($"{item.name}");
        }
    
}

Console.Read();