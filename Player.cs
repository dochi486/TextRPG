namespace TextRPG
{
    public class Player : BattleObject
    {

        public Player(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage) :
            base(name,
                new BattleObjectStat(initHp, initMp, initStr: initStr, initDex: initDex, initMagic: initMagic,
                    initDamage: initDamage))
        {
        }

    }

    public class Archer(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage)
        : Player(name, initHp, initMp, initStr, initDex, initMagic, initDamage)
    {
        public override int GetDamage()
        {
            return this.Stat.Damage + this.Stat.Dex;
        }
    }

    public class Warrior(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage)
        : Player(name, initHp, initMp, initStr, initDex, initMagic, initDamage)
    {
        public override int GetDamage()
        {
            return this.Stat.Damage + this.Stat.Str;
        }
    }

    public class Wizard(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage)
        : Player(name, initHp, initMp, initStr, initDex, initMagic, initDamage)
    {
        public override int GetDamage()
        {
            return this.Stat.Damage + this.Stat.Magic;
        }
    }
}