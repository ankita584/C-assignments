public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    public List<string> VisitedCities { get; set; }

    public static List<Student> GetAll()
    {
        return new List<Student>()
        {
        new Student(){RollNumber = 105, Name = "vishal", Gender = "male", Age = 20,
        VisitedCities = new List<string>(){ "pune"} },
        new Student(){RollNumber = 110, Name = "bharti", Gender = "female", Age = 22
        ,VisitedCities = new List<string>(){ "mumbai", "pune"} },
        new Student(){RollNumber = 2, Name = "ankita", Gender = "female", Age = 25
        ,VisitedCities = new List<string>(){ "satara"} },
        new Student(){RollNumber = 17, Name = "mahesh", Gender = "male", Age = 18
        ,VisitedCities = new List<string>(){ "yavatmal"} },
        new Student(){RollNumber = 49, Name = "prajakta", Gender = "female", Age = 17
        ,VisitedCities = new List<string>(){ "dhule", "nandurbar"} },
        new Student(){RollNumber = 143, Name = "ajinkya", Gender = "male", Age = 32
        ,VisitedCities = new List<string>(){ "nagpur", "akola"} }
        };
    }
}
