namespace TextRPG;

public class MonsterDialogue
{
    public static void SpawnMonster(Monster monster)
    {
        if(monster == null)
            return;
        
        Console.WriteLine($"몬스터 {nameof(monster)}가 나타났습니다!");
        Console.WriteLine($"{nameof(monster)}의 체력은 {monster.Stat.Hp}입니다.");
    }

    public static void KilledMonster(Monster monster)
    {
        if(monster == null)
            return;
        
        Console.WriteLine($"{nameof(monster)}을 처치하고 경험치를 얻었습니다.");
    }
}