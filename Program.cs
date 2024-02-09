// See https://aka.ms/new-console-template for more information

using TextRPG;
using TextRPG.Dialogues.Player;
using TextRPG.Stage;
using TextRPG.Util;

PlayerDialogues.PlayerClassSelect();

var character = Console.ReadLine();

if(character == null)
    character = default;

var player = Stage.CreateCharacter(character);

PlayerDialogues.ActionChoose();

var action = Console.ReadLine();

Stage.MonsterBattle(action, player);

var secondAction = Console.ReadLine();

switch (secondAction)
{
    case "1":
        {
            var orcHp = Util.GetRandom(10);
            var orcMp = Util.GetRandom(10);
            var orcDamage = Util.GetRandom(10);
            var orc = new Orc("오크", orcHp, orcMp, orcDamage);
            
            MonsterDialogue.SpawnMonster(orc);

            StageDialogue.BattleSelectDialogue();

            var playerAction = Console.ReadLine();

            switch (playerAction)
            {
                case "1":
                    {
                        while (orc.Stat.Hp > 0)
                        {
                            var damage = orc.GetDamage();
                            player.Attack(damage);

                            if (player.Stat.Hp <= 0)
                            {
                                PlayerDialogues.PlayerDead();
                                break;
                            }

                            var playerDamage = player.GetDamage();
                            orc.Attack(playerDamage);

                            if (orc.Stat.Hp <= 0)
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


var thirdAction = Console.ReadLine();

switch (thirdAction)
{
    case "1":
        {
            var goblinHp = Util.GetRandom(10);
            var goblinMp = Util.GetRandom(10);
            var goblinDamage = Util.GetRandom(10);
            var goblin = new Goblin("고블린", goblinHp, goblinMp, goblinDamage);
            
            MonsterDialogue.SpawnMonster(goblin);

            StageDialogue.BattleSelectDialogue();

            var playerAction = Console.ReadLine();

            switch (playerAction)
            {
                case "1":
                    {
                        while (goblin.Stat.Hp > 0)
                        {
                            var damage = goblin.GetDamage();
                            player.Attack(damage);

                            if (player.Stat.Hp <= 0)
                            {
                                PlayerDialogues.PlayerDead();
                                break;
                            }

                            var playerDamage = player.GetDamage();
                            goblin.Attack(playerDamage);
                            if (goblin.Stat.Hp <= 0)
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


