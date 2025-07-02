var trainers = trainer.GetAll();
Console.WriteLine("**** ALL TRAINERS ****");
foreach(var trainer in trainers)
{
    Console.WriteLine($"trainer : id : {trainer.Id} name : {trainer.name} experience : {trainer.Experience}");
}

var students = Student.GetAll();
Console.WriteLine("*** ALL STUDENTS ***");
foreach (var s in students)
{
    Console.WriteLine($"student : rollnumber : {s.RollNumber} name : {s.Name} city : {s.City} trainer id : {s.TrainerId}");

}

// inner join

var innerJoin = students.Join(trainers, s => s.TrainerId, t => t.Id, (s, t) => new { SName = s.Name, TName = t.name });
Console.WriteLine("**** inner join result ****");
foreach(var item in innerJoin)
{
    Console.WriteLine($"student name : {item.SName} trainer name : {item.TName}");
}

// left outer join

var leftouterjoin = students.GroupJoin(trainers, s => s.TrainerId, t => t.Id, (s, ts) => new { SName = s.Name, TName = ts.FirstOrDefault(t => t.Id == s.TrainerId)?.name ?? " No Trainer" });
Console.WriteLine($"**** left outer join ****");
foreach(var item in leftouterjoin)
{
    Console.WriteLine($"student name : {item.SName} trainer name : {item.TName}");
}

Console.Read();