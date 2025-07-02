public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public int? TrainerId { get; set; }

    public static List<Student> GetAll()
    {
        return new List<Student>()
        {
        new Student(){ RollNumber = 1, Name = "prathamesh", City = "pune", TrainerId = 1},
        new Student(){ RollNumber = 2, Name = "bharti", City = "mumbai", TrainerId = 1},
        new Student(){ RollNumber = 3, Name = "ajinkya", City = "pune", TrainerId = 2 },
        new Student(){ RollNumber = 4, Name = "bahu", City = "hyd", TrainerId = null},
        new Student(){ RollNumber = 5, Name = "bhalla", City = "hyd", TrainerId = null}
        };
    }
}
