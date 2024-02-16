using TextRPG.BattleObjects.Player;
using TextRPG.Dialogues.Monster;
using TextRPG.Dialogues.Player;
using TextRPG.Dialogues.Stage;

namespace TextRPG.Stages
{
    public static class Stage
    {
        // 몬스터와 플레이어 전투 

        public static void BattleSelect(string action, Player player, Monster monster)
        {
            switch (action)
            {
                case "1":
                {
                    Battle(player, monster);
                }
                break;
                case "2":
                {
                    PlayerDialogues.PlayerRun();
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
            while (IsMonsterAlive(monster) || IsPlayerAlive(player))
            {
                PlayerAttack(player, monster);
                MonsterAttack(player, monster);
            }
        }

        private static bool IsPlayerAlive(Player player) => player.Stat.Hp > 0;
        private static bool IsMonsterAlive(Monster monster) => monster.Stat.Hp > 0;
        
        private static void MonsterAttack(Player player, Monster monster)
        {
            var damage = monster.GetDamage();
            player.Attacked(damage);
        }

        private static void PlayerAttack(Player player, Monster monster)
        {
            var damage = player.GetDamage();
            monster.Attacked(damage);
        }
        
    }
}
