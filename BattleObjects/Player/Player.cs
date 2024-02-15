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
}





