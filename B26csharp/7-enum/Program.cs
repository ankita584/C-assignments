student s1 = new student()
{
    rollnumber = 1,
    name = "avinash",
    gender = "male"

};

Console.WriteLine($"s1 => rollnumber : {s1.rollnumber} name : {s1.name} gender = {s1.gender}");

student s2 = new student()
{
    rollnumber = 2,
    name = "ankita",
    gender = "gender."
};

Console.WriteLine($"s2 => rollnumber : {s2.rollnumber} name : {s2.name} gender = {s2.gender}");

static string getgender(int gender) //method
{
    switch (gender)
    {
        case 1:
            return "male";
        case 2:
            return "female";
        default:
            return "INVALID GENDER";

    }
}

Console.Read();