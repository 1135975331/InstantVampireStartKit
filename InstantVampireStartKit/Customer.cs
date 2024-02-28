namespace InstantVampireStartKit;

public enum StatusType
{
    CONFINED_IN_THE_DARKNESS,
    IMMERSED_IN_THE_TRUE_DARKNESS
}

public class Customer
{
    public Customer(StatusType status, bool isAwayFromTheWorldOfLight = true)
    {
        IsAwayFromTheWorldOfLight = isAwayFromTheWorldOfLight;
        SetStatus(status);
    }
    
    public Race Race { get; set; } = new Human();
    public StatusType PlayerStatus { get; set; }
    public bool IsAwayFromTheWorldOfLight { get; set; }

    public void SetStatus(StatusType status)
    {
        PlayerStatus = status;
        
        switch(status) {
            case StatusType.CONFINED_IN_THE_DARKNESS:
                Console.Write("어둠 속에 유페당한 ");
                break;
            case StatusType.IMMERSED_IN_THE_TRUE_DARKNESS:
                Console.WriteLine("진정한 어둠에 취해보시오");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(status), status, null);
        }
    }

    public bool GetIsAwayFromTheWorldOfLight()
    {
        Console.Write($"빛의 세계와 {(IsAwayFromTheWorldOfLight ? "고별한" : "재회한")} ");
        return IsAwayFromTheWorldOfLight;
    }

    public void ChangeRace(Race race)
    {
        Race = race;
        Console.Write("너도 뱀파이어, ");
    }
}