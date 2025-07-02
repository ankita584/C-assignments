using System.Diagnostics.CodeAnalysis;

public class studenthelper : IEqualityComparer<student>
{
    public bool Equals(student? x, student? y)
    { 
        return x.rollnumber.Equals(y.rollnumber) && x.name.Equals(y.name) && x.gender.Equals(y.gender) && x.age.Equals(y.age);
    }


    public int GetHashCode([DisallowNull] student obj)
    {
        return obj.rollnumber.GetHashCode() ^ obj.name.GetHashCode() ^ obj.gender.GetHashCode() ^ obj.age.GetHashCode();

    }
}
