public class engine
{
    public int powerInCC { get; set; }
}

public class car
{
    public engine engine { get; set; }

    public car()
    {
        engine = new engine() { powerInCC = 1400 };
    }
}