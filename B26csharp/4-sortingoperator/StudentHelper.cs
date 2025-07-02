public class studenthelper : IComparer<student>
{
    public int Compare(student?x, student? y)
    {
        return x.gender.CompareTo(y.gender); // sort on basis of gender
    }
}