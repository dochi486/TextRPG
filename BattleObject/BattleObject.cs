
namespace TextRPG
{
    public class BattleObject()
    {
        public string Name { get; set; }

        public struct BattleObjectStat(int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage)
        {
            public int Hp { get; set; } = initHp;
            public int Mp { get; set; } = initMp;
            public int Str { get; set; } = initStr;
            public int Dex { get; set; } = initDex;
            public int Magic { get; set; } = initMagic;
            public int Damage { get; set; } = initDamage;
        }

        public BattleObjectStat Stat;


        public BattleObject(string name, BattleObjectStat stat) : this()
        {
            this.Name = name;
            Stat = stat;
        }

        public void Attack(int damage)
        {
            BattleObjectStat modifiedStat = Stat;
            modifiedStat.Hp -= damage;
            Stat = modifiedStat;
        }

        public virtual int GetDamage()
        {
            Random random = new Random();
            return random.Next(1, Stat.Damage);
        }
    }
}
