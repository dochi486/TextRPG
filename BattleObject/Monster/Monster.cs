
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



}
