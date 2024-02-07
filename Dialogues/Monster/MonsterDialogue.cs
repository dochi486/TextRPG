namespace TextRPG;

public class MonsterDialogue
{
    public static void SpawnMonster(Monster monster)
    {
        Console.WriteLine($"몬스터 {nameof(monster)}가 나타났습니다!");
        Console.WriteLine($"{nameof(monster)}의 체력은 {monster.Stat.Hp}입니다.");
    }
}