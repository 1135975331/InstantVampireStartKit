namespace InstantVampireStartKit;

public enum Flavor 
{
    STRAWBERRY, GRAPE
}

public class VampireConversionContractKit_TM(decimal price, bool isLimitedSalePrice)
{
    public decimal Price { get; protected set; } = price;
    public bool IsLimitedSalePrice { get; protected set; } = isLimitedSalePrice;
}

public class FirstTimeSpecialFakeBloodSet : VampireConversionContractKit_TM
{
    private float _currentAmount = 360;

    public FirstTimeSpecialFakeBloodSet(decimal price, Flavor flavor, bool isLimitedSalePrice) : base(price, isLimitedSalePrice)
    {
        Flavor = flavor;
        Console.Write($"{price}원 {(isLimitedSalePrice ? "한정" : "통상")} 판매가 ");
    }

    public int OptionNum { get; private set; } = 1;
    public Flavor Flavor { get; private set; }
    public float Capacity { get; private set; } = 360;
    public float CurrentAmount {
        get => _currentAmount;
        set {
            _currentAmount = value >= 0 ? value : 0;
            Console.Write("초회특전 모조 피를 흡혈하며 ");  // 흡혈[吸血]: 피를 빨아들임.
        }
    }
}