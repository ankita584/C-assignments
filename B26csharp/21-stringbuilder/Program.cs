using System.Text;

string s = "hi";
s += "my";   // append // concat
s += "name";
s += "is";
s += "ankita";

Console.WriteLine(s);

StringBuilder sb = new StringBuilder("my ");
sb.Append("name ");
sb.Append("is ");
sb.Append("ankita ");

Console.WriteLine(sb.ToString());
    

Console.Read();