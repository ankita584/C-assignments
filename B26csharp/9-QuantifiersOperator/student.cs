public class student
{
    public int rollnumber { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public int age { get; set; }

    public static List<student> GetAll()
    {
        return new List<student>()
        {
            new student() { rollnumber = 105, name = "guru", gender = "male", age = 20 },
            new student() { rollnumber = 110, name = "ankita", gender = "female", age = 22 },
            new student() { rollnumber = 2, name = "anvi", gender = "female", age = 25 },
            new student() { rollnumber = 17, name = "gokul", gender = "male", age = 18 },
            new student() { rollnumber = 49, name = "aarvi", gender = "female", age =  17 },
            new student() { rollnumber = 143, name = "avinash", gender = "male", age = 32 },
        };
    }


    //public override bool Equals(object? obj)
    //{
    //    student s = obj as student;
    //    return this.rollnumber.Equals(s.rollnumber) && this.name.Equals(s.name) && this.gender.Equals(s.gender) && this.age.Equals(s.age);
    //}

    //public override int GetHashCode()
    //{
    //    return this.rollnumber.GetHashCode() ^ this.name.GetHashCode() ^ this.gender.GetHashCode() ^ this.age.GetHashCode();
    //}
}

