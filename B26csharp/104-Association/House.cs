public class room
{
    public string roomtype { get; set; }
    public int dimension { get; set; }
}

//composition association

public class house //parent
{
    public room[] rooms { get; set; } //child

    public house()
    {
        rooms = new room[]
        {
            new room(){roomtype ="bedroom", dimension = 10},
            new room(){roomtype = "pantry", dimension = 10}
        };
    }
}
