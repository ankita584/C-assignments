#region using integral constant

//public class student
//{
//    public int rollnumber { get; set; }

//    public string name { get; set; }

//    public string gender { get; set; }
//}

#endregion integral constant


#region using enum 

using Microsoft.VisualBasic.FileIO;

public class student
{
    public int rollnumber { get; set; }

    public string name { get; set; }

    public gender gender { get; set; }
}

public enum gender
{
    male,female
}

#endregion using enum