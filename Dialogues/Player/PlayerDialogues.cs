namespace TextRPG.Dialogues.Player;

public static class PlayerDialogues
{
    public static void PlayerClassSelect()
    {
        Console.WriteLine("클래스를 선택하세요.");
        Console.WriteLine("1. 마법사");
        Console.WriteLine("2. 전사");
        Console.WriteLine("3. 궁수");
    }

    public static void PlayerStatShow(BattleObjects.Player.Player player)
    {
        if(player == null)
            return;

        Console.WriteLine($"당신의 직업은 : {player.Name}입니다.");
        Console.WriteLine($"당신의 체력은 : {player.Stat.Hp}입니다.");
        Console.WriteLine($"당신의 마력은 : {player.Stat.Mp}입니다.");
    }

    public static void PlayerRest()
    {
        Console.WriteLine("쉬기");
        Console.WriteLine("당신은 영원히 잠들었습니다.");
        Console.WriteLine("The End");
    }

    public static void PlayerRun()
    {
        Console.WriteLine("당신은 사냥터에서 도망쳐서 영원히 패배자로 낙인이 찍혔습니다.");
        Console.WriteLine("The End");
    }

    public static void PlayerDead()
    {
        Console.WriteLine("플레이어 사망");
        Console.WriteLine("The End");
    }

    public static void PlayerHPIncreased(int inHp)
    {
        Console.WriteLine($"당신의 체력이 {inHp}만큼 올랐습니다.");
    }

    public static void ActionChoose()
    {
        Console.WriteLine("무엇을 하시겠습니까?");
        Console.WriteLine("1. 사냥하기");
        Console.WriteLine("2. 쉬기");
    }

    public static void EndJourney()
    {
        Console.WriteLine("고블린을 처치했습니다. 여행이 끝났습니다.");
    }
}