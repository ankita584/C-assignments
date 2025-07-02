public class Mathcalculator<T1, T2, T3>
{
    public T1 number1;
    public T2 number2;

    public T3 add()
    {
        dynamic n1 = number1;
        dynamic n2 = number2;

        return n1 + n2;
    }
}