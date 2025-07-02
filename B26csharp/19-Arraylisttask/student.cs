
using System;
using System.Collections;


public class student
{
    public int Rollnumber { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }


    public student(int rollnumber, string name, string gender)
    {
        Rollnumber = rollnumber;
        Name = name;
        Gender = gender;
    }

    public override string ToString()
    {
        return ($"rollnumber : {Rollnumber} , name : {Name} , gender : {Gender}");
    }
    

}