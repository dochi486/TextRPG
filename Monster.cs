
namespace TextRPG
{
    public class Monster : BattleObject
    {

        public Monster(string name, int hp, int mp, int damage) : base(name,
            new BattleObjectStat(hp, mp, 0, 0, 0, initDamage: damage))
        {
            Stat.Hp = hp;
            Stat.Mp = mp;
            Stat.Damage = damage;
        }
    }

    public class Slime(string name, int initHp, int initMp, int initDamage)
        : Monster(name, initHp, initMp, initDamage);

    public class Goblin(string name, int initHp, int initMp, int initDamage)
        : Monster(name, initHp, initMp, initDamage);

    public class Orc(string name, int initHp, int initMp, int initDamage)
        : Monster(name, initHp, initMp, initDamage);
}
