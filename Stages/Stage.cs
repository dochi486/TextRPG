using TextRPG.BattleObjects.Player;
using TextRPG.Dialogues.Monster;
using TextRPG.Dialogues.Player;
using TextRPG.Dialogues.Stage;

namespace TextRPG.Stages
{
    public static class Stage
    {
        // 몬스터와 플레이어 전투 

        public static void BattleSelect(Player player, Monster monster)
        {
            var action = Console.ReadLine();

            switch (action)
            {
                case "1":
                {
                    MonsterDialogue.SpawnMonster(monster.Name, monster);
                    StageDialogue.BattleSelectDialogue();
                    Battle(player, monster);
                }
                break;
                case "2":
                {
                    PlayerDialogues.PlayerRest();
                }
                break;
                default:
                {
                    Console.WriteLine("잘못된 선택입니다");
                }
                break;
            }
        }
        
        private static void Battle(Player player, Monster monster)
        {
            var attack = Console.ReadLine();

            switch (attack)
            {
                case "1":
                {
                    Attack(player, monster);
                } 
                break;
                case "2":
                {
                    PlayerDialogues.PlayerRun();
                }
                break;
                default:
                {
                    Console.WriteLine("잘못된 선택입니다.");
                }
                break;
            }

        }

        private static void Attack(Player player, Monster monster)
        {
            while (IsMonsterAlive(monster))
            {
                PlayerAttack(player, monster);
                MonsterAttack(player, monster);


                if (false == IsPlayerAlive(player))
                {
                    PlayerDialogues.PlayerDead();
                    break;
                }

                if (false == IsMonsterAlive(monster))
                {
                    if(monster.Name is "Goblin")
                        PlayerDialogues.EndJourney();
                    else
                        MonsterDialogue.KilledMonster(monster.Name);
                    break;
                }
                
            }
        }

        private static bool IsPlayerAlive(Player player) => player.Stat.Hp > 0;
        private static bool IsMonsterAlive(Monster monster) => monster.Stat.Hp > 0;
        
        private static void MonsterAttack(Player player, Monster monster)
        {
            var damage = monster.GetDamage();
            player.Attacked(damage);
            MonsterDialogue.AttackPlayer(damage);
        }

        private static void PlayerAttack(Player player, Monster monster)
        {
            var damage = player.GetDamage();
            monster.Attacked(damage);
            PlayerDialogues.PlayerAttack(damage);
        }
        
    }
}
