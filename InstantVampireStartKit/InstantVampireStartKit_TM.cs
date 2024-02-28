// 어둠속에 유폐당한 고독한 밤의 친우여
// 39800원 한정 판매가 전향계약키트™를 추천하오
// 빛의 세계와 고별한 굳게 잠근 방문이여
// 초회특전 모조피를 흡혈하며 진정한 어둠에 취해보시오
// 너도 뱀파이어 나도 뱀파이어

namespace InstantVampireStartKit;

public static class InstantVampireStartKit_TM
{
    public static void Main()
    {
        var you = new Customer(status: StatusType.CONFINED_IN_THE_DARKNESS);
        var me = new LavieenRealRose(relationship: "고독한 밤의 친우");

        var conversionContractKit_TM = new FirstTimeSpecialFakeBloodSet(price: 39800, flavor: Flavor.STRAWBERRY, isLimitedSalePrice: true);
        me.Recommend(vampireKit: conversionContractKit_TM, recommendTo: you);

        you.GetIsAwayFromTheWorldOfLight();
        var door = new Door(isClosed: true);

        you.DrinkBlood(vampireKit: conversionContractKit_TM);

        you.ChangeRace(new Vampire());
        me.ChangeRace(new Vampire());
    }

    private static void DrinkBlood(this Customer customer, VampireConversionContractKit_TM vampireKit)
    {
        ((FirstTimeSpecialFakeBloodSet)vampireKit).CurrentAmount -= 100;
        customer.SetStatus(status: StatusType.IMMERSED_IN_THE_TRUE_DARKNESS);
    }
}