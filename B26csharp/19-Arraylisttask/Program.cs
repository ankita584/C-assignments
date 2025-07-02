using System.Collections;

ArrayList Student = new ArrayList();

Console.WriteLine("*** ADDING STUDENTS ***");

student s1 = new student(1, "ankita", "female");
student s2 = new student(2, "bharti", "female");
student s3 = new student(3, "avinash", "male");
student s4 = new student(4, "shivani", "female");


// adding new students

Student.Add(s1);
Student.Add(s2);
Student.Add(s3);
Student.Add(s4);

displaystudent(Student);


// Add new student at a particular index

Console.WriteLine("Adding new student at particular index");
student s5 = new student(5, "anvi", "female");

Student.Insert(0, s5);

displaystudent(Student);

//remove a student from specific index

Console.WriteLine("Removing student at particular index");
Student.RemoveAt(1);

displaystudent(Student);

static void displaystudent(ArrayList students)
{
    Console.WriteLine("current student list");
    foreach(student s in students)
    {
        Console.WriteLine($"{s}");
    }
}


Console.Read();