namespace TextRPG;

public class MonsterDialogue
{
    public static Orc SpawnOrc()
    {
        var orcHp = Util.GetRandom(10);
        var orcMp = Util.GetRandom(10);
        var orcDamage = Util.GetRandom(10);
        Orc orc = new Orc("오크", orcHp, orcMp, orcDamage);
        Console.WriteLine($"몬스터 {nameof(orc)}가 나타났습니다!");
        Console.WriteLine($"{nameof(orc)}의 체력은 {orc.Stat.Hp}입니다.");

        return orc;
    }
}