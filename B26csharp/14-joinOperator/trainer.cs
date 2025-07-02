public class trainer
{
    public int Id { get; set; }
    public string name { get; set; }
    public int Experience { get; set; }

    public static List<trainer> GetAll()
    {
        return new List<trainer>()
        {
            new trainer(){Id = 1, name = "vikul", Experience = 14},
            new trainer(){Id = 2, name = "usha", Experience = 3},
            new trainer(){Id = 3, name = "atul", Experience = 4}

        };
    }
}