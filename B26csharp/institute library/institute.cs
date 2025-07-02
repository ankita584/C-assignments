public delegate bool IsEligibleForDiscount(student student);

public class institute
{
    public string name { get; set; }

    private student[] _students;

    public institute(student[] students)
    {
        _students = students;
    }

    public void details()
    {
        Console.WriteLine("*** INSTITUTE DETAILS ***");
        Console.WriteLine($"name : {name}");

        Console.WriteLine("*** ALL STUDENTS ***");

        if (_students != null && _students.Length > 0)
        {
            foreach (student s in _students)
            {
                Console.WriteLine($"name : {s.name} gender : {s.gender} DOB : {s.dateofbirth}");
            }
        }
        else
        {
            Console.WriteLine("NO STUDENTS BELONGS TO THIS INSTITUTE");
        }

    }

    public void StudentEligibleForDiscountInFees(IsEligibleForDiscount isEligibleForDiscount)
    {
        Console.WriteLine("*** ALL ELIGIBLE STUDENTS FOR DISCOUNT ***");

        foreach (student s in _students)
        {
            //if (s.name.StartsWith("b"))
            if (isEligibleForDiscount(s)) 
            {
                Console.WriteLine($"{name} eligible");
            }


        }


    }
}