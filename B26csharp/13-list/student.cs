public class student
{
    public int rollnumber { get; set; }
    public string name { get; set; }
    public string city { get; set; }

    public override bool Equals(object? obj)
    {
        student s = (student)obj;
        return this.rollnumber.Equals(s.rollnumber) &&
            this.name.Equals(s.name) &&
            this.city.Equals(s.city);
    }
}