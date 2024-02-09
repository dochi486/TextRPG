
using TextRPG.Dialogues.Player;

namespace TextRPG.Stage
{
    public class Stage
    {
        public static Player CreateCharacter(string character) 
        {
            Player player;

            var initHp = TextRPG.Util.Util.GetRandom(10);
            var initMp = TextRPG.Util.Util.GetRandom(10);
            var initStr = TextRPG.Util.Util.GetRandom(10);
            var initDex = TextRPG.Util.Util.GetRandom(10);
            var initMagic = TextRPG.Util.Util.GetRandom(10);
            var initDamage = TextRPG.Util.Util.GetRandom(10);


            switch(character)
            {
                case "1":
                    {
                        Console.WriteLine("마법사 선택");
                        player = new Wizard("마법사", initHp, initMp, initStr, initDex, initMagic, initDamage);
                        PlayerDialogues.PlayerStatShow(player);
                        return player;
                    }
                case "2":
                    {
                        Console.WriteLine("전사 선택");
                        player = new Warrior("전사", initHp, initMp, initStr, initDex, initMagic, initDamage);
                        PlayerDialogues.PlayerStatShow(player);
                        return player;
                    }
                case "3":
                    {
                        Console.WriteLine("궁수 선택");
                        player = new Archer("궁수", initHp, initMp, initStr, initDex, initMagic, initDamage);
                        PlayerDialogues.PlayerStatShow(player);
                        return player;
                    }
                default:
                    {
                        player = new Player("플레이어", initHp, initMp, initStr, initDex, initMagic, initDamage);
                        return player;
                    }
            }
        }

        public static void MonsterBattle(string action, Player player)
        {
            switch(action)
            {
                case "1":
                    {
                        var slimeHp = TextRPG.Util.Util.GetRandom(10);
                        var slimeMp = TextRPG.Util.Util.GetRandom(10);
                        var slimeDamage = TextRPG.Util.Util.GetRandom(10);

                        var slime = new Slime("슬라임", slimeHp, slimeMp, slimeDamage);

                        MonsterDialogue.SpawnMonster(slime);

                        StageDialogue.BattleSelectDialogue();

                        var playerAction = Console.ReadLine();

                        switch(playerAction)
                        {
                            case "1":
                                {
                                    while(slime.Stat.Hp > 0)
                                    {
                                        var damage = slime.GetDamage();
                                        player.Attack(damage);

                                        if(player.Stat.Hp <= 0)
                                        {
                                            PlayerDialogues.PlayerDead();
                                            break;
                                        }

                                        var playerDamage = player.GetDamage();
                                        slime.Attack(playerDamage);
                                        if(slime.Stat.Hp <= 0)
                                        {
                                            MonsterDialogue.KilledMonster(slime);
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
            }

        }
    }
}
