public class car
{
    public string name { get; set; }

    public car()
    {
        name = "Regular Normal Car";
    }
}
    public class Audi : car
    {
        public Audi()
        {
            name = "Audi";
        }
    }

    public class BMW : car
    {
        public BMW()
        {
            name = "BMW";
        }
    }
    public class Dzire : car
    {
        public Dzire()
        {
            name = "Dzire";
        }
    }
