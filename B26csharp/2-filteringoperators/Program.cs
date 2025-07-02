List<student> students = new List<student>()
{
    new student(){ rollnumber = 1, name = "ankita", age = 25, city = "pune" },
    new student(){ rollnumber = 1, name = "akansha", age = 21, city = "mumbai" },
    new student(){ rollnumber = 1, name = "anvi", age = 20, city = "pune" },
    new student(){ rollnumber = 1, name = "shivani", age = 22, city = "satara" },
    new student(){ rollnumber = 1, name = "aarvi", age = 18, city = "mumbai" },

};

Console.WriteLine("*** All Students ***");
foreach(student s in students)
{
    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} age : {s.age} city : {s.city}");

}

//filter all students who belongs to pune city

var students1 = students.Where(s => s.city.Equals("pune"));
foreach(student s in students1)
{
    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} age : {s.age} city : {s.city}");
}


//filter all students who bleongs to pune city bd age less than 24

students1 = students.Where(s=>s.city.Equals("pune") && s.age < 24 );

Console.WriteLine("*** All students from pune city & age less than 24 ***");
foreach(student s in students1)
{
    Console.WriteLine($"rollnumber : {s.rollnumber}  name : {s.name} age : {s.age} city : {s.city}" );
   
}

//multi type item collection

List<object> list = new List<object>() { 10, "ankita", '$', 20, 15, 15.4f, "anvi" };

//filter only int type item using where
//var students2 = list.Where(0 => o.GetType().name == "Int32");
//var students2 = list.Where(o => o.GetType().Name == "String");

//var students2 = list.OfType<int>(); / using oftype
var students2 = list.OfType<string>();


foreach(var o in students2)
{
    Console.Write($"{o}\t");
}
Console.WriteLine();
Console.Read();