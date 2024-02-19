using TextRPG.BattleObjects.Player;
using TextRPG.Dialogues.Player;
using TextRPG.Utils;

namespace TextRPG.Factories;

public static class PlayerClassFactory
{
    public static Player CreateCharacter()
    {
        var character = Console.ReadLine();
        
        Player player = null;

        var initHp = Util.GetRandom(10);
        var initMp = Util.GetRandom(10);
        var initStr = Util.GetRandom(10);
        var initDex = Util.GetRandom(10);
        var initMagic = Util.GetRandom(10);
        var initDamage = Util.GetRandom(10);
        
        switch(character)
        {
            case "1":
            {
                player = new Wizard("마법사", initHp, initMp, initStr, initDex, initMagic, initDamage);
                break;
            }
            case "2":
            {
                player = new Warrior("전사", initHp, initMp, initStr, initDex, initMagic, initDamage);
                break;
            }
            case "3":
            {
                player = new Archer("궁수", initHp, initMp, initStr, initDex, initMagic, initDamage);
                break;
            }
            default:
            {
                player = new Player("플레이어", initHp, initMp, initStr, initDex, initMagic, initDamage);
                break;
            }
        }
        
        return player;
    }
}