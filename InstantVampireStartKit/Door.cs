namespace InstantVampireStartKit;

public class Door
{
    public Door(bool isClosed)
    {
        IsClosed = isClosed;
        Console.WriteLine($"{(isClosed ? "굳게 잠근" : "잠그지 않은")} 방문이여");
    }
    public bool IsClosed { get; set; }
}