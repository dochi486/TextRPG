// See https://aka.ms/new-console-template for more information

using TextRPG;
using TextRPG.BattleObjects.Player;
using TextRPG.Dialogues.Player;
using TextRPG.Factories;
using TextRPG.Stages;

while(true)
{
    PlayerDialogues.PlayerClassSelect();

    var character = Console.ReadLine();
    
    Player player = PlayerClassFactory.CreateCharacter(character);
    PlayerDialogues.PlayerStatShow(player);

    PlayerDialogues.ActionChoose();

    var action = Console.ReadLine();
    
    for (int i = 1; i <= StageInfo.StageDictionary.Count; i++)
    { 
        Monster monster = MonsterFactory.CreateMonster(StageInfo.StageDictionary[i]);
        Stage.BattleSelect(action, player, monster);
    }
}



