
public static class stringhelper
{
    public static string MakeFirstLetterCapital( this string value)
    {
        string result = string.Empty;
        for (int i = 0; i < value.Length; i++) 
        {
            if(i==0)
            {
                result += value[i].ToString().ToUpper();
            }
            else
                result += value[i].ToString();
        }
        return result;
    }
}