public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    public static List<Student> GetAll()
    {
        return new List<Student>()
        {
        new Student(){RollNumber = 105, Name = "vishal", Gender = "male", Age = 20},
        new Student(){RollNumber = 110, Name = "bharti", Gender = "female", Age = 22},
        new Student(){RollNumber = 2, Name = "ankita", Gender = "female", Age = 25},
        new Student(){RollNumber = 17, Name = "mahesh", Gender = "male", Age = 18},
        new Student(){RollNumber = 49, Name = "prajakta", Gender = "female", Age = 17},
        new Student(){RollNumber = 143, Name = "ajinkya", Gender = "male", Age = 32}
        };
    }
}

