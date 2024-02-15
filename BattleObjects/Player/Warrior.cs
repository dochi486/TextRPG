namespace TextRPG.BattleObjects.Player;

public class Warrior(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage)
    : Player(name, initHp, initMp, initStr, initDex, initMagic, initDamage)
{
    public override int GetDamage()
    {
        return this.Stat.Damage + this.Stat.Str;
    }
}