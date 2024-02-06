namespace TextRPG.Dialogues.Player;

public class PlayerDialogues
{
    public static void PlayerClassSelect()
    {
        Console.WriteLine("클래스를 선택하세요.");
        Console.WriteLine("1. 마법사");
        Console.WriteLine("2. 전사");
        Console.WriteLine("3. 궁수");
    }

    public static void PlayerStatShow()
    {

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
}