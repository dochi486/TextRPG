namespace TextRPG.Dialogues.Monster;

public static class MonsterDialogue
{
    public static void SpawnMonster(string name, TextRPG.Monster monster)
    {
        if(monster == null)
            return;
        
        Console.WriteLine($"몬스터 {name}가 나타났습니다!");
        Console.WriteLine($"{name}의 체력은 {monster.Stat.Hp}입니다.");
    }

    public static void KilledMonster(string name)
    {
        Console.WriteLine($"{name}을 처치하고 경험치를 얻었습니다.");
    }
}