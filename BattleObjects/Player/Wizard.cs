namespace TextRPG.BattleObjects.Player;

public class Wizard(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage)
    : Player(name, initHp, initMp, initStr, initDex, initMagic, initDamage)
{
    public override int GetDamage()
    {
        return this.Stat.Damage + this.Stat.Magic;
    }
}
