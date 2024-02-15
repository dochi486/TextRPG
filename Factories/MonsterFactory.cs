﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Stage
{
    public enum EMonsterType
    {
        None,
        Slime,
        Orc,
        Goblin
    }

    public class MonsterFactory
    {

        public static Monster CreateMonster(EMonsterType eMonsterType)
        {
            Monster monster = null;

            var initHp = Util.Util.GetRandom(10);
            var initMp = Util.Util.GetRandom(10);
            var initDamage = Util.Util.GetRandom(10);

            switch(eMonsterType)
            {
                case EMonsterType.Slime:
                    monster = new Slime("슬라임", initHp, initMp, initDamage);
                    break;
                case EMonsterType.Orc:
                    monster = new Orc("오크", initHp, initMp, initDamage);
                    break;
                case EMonsterType.Goblin:
                    monster = new Goblin("고블린", initHp, initMp, initDamage);
                    break;
            
            }

            return monster;
        }
    }
}
