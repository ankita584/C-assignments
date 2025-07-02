public class calculator
{
    public IEnumerable<int> GetEvenNumbers(List<int> numbers)
    {
       // List<int> result = new List<int>(); //temporary collection

        foreach(int number in numbers)
        {
            if (number % 2 == 0)
            {
                yield return number;
                //result.add(number)
            }
        }
    }
}