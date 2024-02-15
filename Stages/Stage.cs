using TextRPG.BattleObjects.Player;
using TextRPG.Dialogues.Monster;
using TextRPG.Dialogues.Player;
using TextRPG.Dialogues.Stage;
using TextRPG.Utils;

namespace TextRPG.Stages
{
    public class Stage
    {
        public static void MonsterBattle(string action, Player player, Monster monster)
        {
            switch(action)
            {
                case "1":
                    {
                        MonsterDialogue.SpawnMonster(monster.Name, monster);

                        StageDialogue.BattleSelectDialogue();

                        var playerAction = Console.ReadLine();

                        switch(playerAction)
                        {
                            case "1":
                                {
                                    while(monster.Stat.Hp > 0)
                                    {
                                        var damage = monster.GetDamage();
                                        player.Attack(damage);

                                        if(player.Stat.Hp <= 0)
                                        {
                                            PlayerDialogues.PlayerDead();
                                            break;
                                        }

                                        var playerDamage = player.GetDamage();
                                        monster.Attack(playerDamage);
                                        if(monster.Stat.Hp <= 0)
                                        {
                                            MonsterDialogue.KilledMonster(monster.Name);
                                            player.Stat.Hp += 10;
                                            PlayerDialogues.PlayerHPIncreased(10);

                                            PlayerDialogues.ActionChoose();
                                            break;
                                        }
                                    }
                                }
                                break;
                            case "2":
                                {
                                    PlayerDialogues.PlayerRun();
                                }
                                break;
                        }
                    }
                    break;
                case "2":
                    {
                        PlayerDialogues.PlayerRest();
                    }
                    break;
                default:
                {
                    Console.WriteLine("잘못된 선택입니다.");
                } 
                break;
            }
        }
    }
}
