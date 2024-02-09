
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


        public static void MonsterBattleStage1(string action, Player player)
        {
            switch(action)
            {
                case "1":
                    {
                        var slimeHp = TextRPG.Util.Util.GetRandom(10);
                        var slimeMp = TextRPG.Util.Util.GetRandom(10);
                        var slimeDamage = TextRPG.Util.Util.GetRandom(10);

                        Slime slime = new Slime("슬라임", slimeHp, slimeMp, slimeDamage);

                        MonsterDialogue.SpawnMonster(slime.Name, slime);

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

        public static void MonsterBattleStage2(string action, Player player)
        {
            switch(action)
            {
                case "1":
                    {
                        var orcHp = TextRPG.Util.Util.GetRandom(10);
                        var orcMp = TextRPG.Util.Util.GetRandom(10);
                        var orcDamage = TextRPG.Util.Util.GetRandom(10);
                        Orc orc = new Orc("오크", orcHp, orcMp, orcDamage);

                        MonsterDialogue.SpawnMonster(orc.Name, orc);

                        StageDialogue.BattleSelectDialogue();

                        var playerAction = Console.ReadLine();

                        switch(playerAction)
                        {
                            case "1":
                                {
                                    while(orc.Stat.Hp > 0)
                                    {
                                        var damage = orc.GetDamage();
                                        player.Attack(damage);

                                        if(player.Stat.Hp <= 0)
                                        {
                                            PlayerDialogues.PlayerDead();
                                            break;
                                        }

                                        var playerDamage = player.GetDamage();
                                        orc.Attack(playerDamage);

                                        if(orc.Stat.Hp <= 0)
                                        {
                                            MonsterDialogue.KilledMonster(orc);
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

        public static void MonsterBattleStage3(string action, Player player)
        {

            switch(action)
            {
                case "1":
                    {
                        var goblinHp = TextRPG.Util.Util.GetRandom(10);
                        var goblinMp = TextRPG.Util.Util.GetRandom(10);
                        var goblinDamage = TextRPG.Util.Util.GetRandom(10);
                        Goblin goblin = new Goblin("고블린", goblinHp, goblinMp, goblinDamage);

                        MonsterDialogue.SpawnMonster(goblin.Name, goblin);

                        StageDialogue.BattleSelectDialogue();

                        var playerAction = Console.ReadLine();

                        switch(playerAction)
                        {
                            case "1":
                                {
                                    while(goblin.Stat.Hp > 0)
                                    {
                                        var damage = goblin.GetDamage();
                                        player.Attack(damage);

                                        if(player.Stat.Hp <= 0)
                                        {
                                            PlayerDialogues.PlayerDead();
                                            break;
                                        }

                                        var playerDamage = player.GetDamage();
                                        goblin.Attack(playerDamage);
                                        if(goblin.Stat.Hp <= 0)
                                        {
                                            MonsterDialogue.KilledMonster(goblin);
                                            player.Stat.Hp += 10;
                                            PlayerDialogues.PlayerHPIncreased(10);

                                            PlayerDialogues.EndJourney();
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
