// See https://aka.ms/new-console-template for more information

using TextRPG.Dialogues.Player;
using TextRPG.Stage;

PlayerDialogues.PlayerClassSelect();

var character = Console.ReadLine();

if(character == null)
    character = default;

var player = Stage.CreateCharacter(character);

PlayerDialogues.ActionChoose();

var action = Console.ReadLine();

Stage.MonsterBattleStage1(action, player);

var secondAction = Console.ReadLine();

Stage.MonsterBattleStage2(secondAction, player);

var thirdAction = Console.ReadLine();

Stage.MonsterBattleStage3(thirdAction, player);


