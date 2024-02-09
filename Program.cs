// See https://aka.ms/new-console-template for more information

using TextRPG;
using TextRPG.Dialogues.Player;
using TextRPG.Stage;

PlayerDialogues.PlayerClassSelect();

var character = Console.ReadLine();

if(character == null)
    character = default;

var player = Stage.CreateCharacter(character);

PlayerDialogues.ActionChoose();

var action = Console.ReadLine();

var slimeHp = TextRPG.Util.Util.GetRandom(10);
var slimeMp = TextRPG.Util.Util.GetRandom(10);
var slimeDamage = TextRPG.Util.Util.GetRandom(10);

Slime slime = new Slime("슬라임", slimeHp, slimeMp, slimeDamage);

Stage.MonsterBattle(action, player, slime);

var secondAction = Console.ReadLine();

var orcHp = TextRPG.Util.Util.GetRandom(10);
var orcMp = TextRPG.Util.Util.GetRandom(10);
var orcDamage = TextRPG.Util.Util.GetRandom(10);
Orc orc = new Orc("오크", orcHp, orcMp, orcDamage);

Stage.MonsterBattle(secondAction, player, orc);


var thirdAction = Console.ReadLine();

var goblinHp = TextRPG.Util.Util.GetRandom(10);
var goblinMp = TextRPG.Util.Util.GetRandom(10);
var goblinDamage = TextRPG.Util.Util.GetRandom(10);
Goblin goblin = new Goblin("고블린", goblinHp, goblinMp, goblinDamage);

Stage.MonsterBattle(thirdAction, player, goblin);


