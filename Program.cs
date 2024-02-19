// See https://aka.ms/new-console-template for more information

using TextRPG;
using TextRPG.BattleObjects.Player;
using TextRPG.Dialogues.Player;
using TextRPG.Dialogues.Stage;
using TextRPG.Factories;
using TextRPG.Stages;

while(true)
{
    PlayerDialogues.PlayerClassSelect();

    Player player = PlayerClassFactory.CreateCharacter();
    PlayerDialogues.PlayerStatShow(player);


    
    for (int i = 1; i <= StageInfo.StageDictionary.Count; i++)
    { 
        PlayerDialogues.ActionChoose();
        Monster monster = MonsterFactory.CreateMonster(StageInfo.StageDictionary[i]);
        Stage.BattleSelect(player, monster);
    }
}



