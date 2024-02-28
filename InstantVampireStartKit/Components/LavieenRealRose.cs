namespace InstantVampireStartKit;

public class LavieenRealRose
{
    public LavieenRealRose(string relationship)
    {
        RelationShip = relationship;
        Console.WriteLine($"{relationship}여");
    }
    public Race Race { get; set; } = new Vampire();
    public string Name { get; set; } = "김장미";
    public string RelationShip { get; set; }
    public bool IsAwayFromTheWorldOfLight { get; set; } = true;

    public void Recommend(VampireConversionContractKit_TM vampireKit, Customer recommendTo)
    {
        Console.WriteLine("전향 계약 키트™를 추천하오");
    }

    public void ChangeRace(Race race)
    {
        Race = race;
        Console.WriteLine("나도 뱀파이어");
    }
}