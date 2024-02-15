// See https://aka.ms/new-console-template for more information

using TextRPG;
using TextRPG.Dialogues.Player;
using TextRPG.Factories;
using TextRPG.Stages;

while(true)
{
    PlayerDialogues.PlayerClassSelect();

    var character = Console.ReadLine();
    
    Player player = Stage.CreateCharacter(character);

    PlayerDialogues.ActionChoose();

    var action = Console.ReadLine();
    
    for (int i = 1; i <= StageInfo.StageDictionary.Count; i++)
    { 
        Monster monster = MonsterFactory.CreateMonster(StageInfo.StageDictionary[i]);
        Stage.MonsterBattle(action, player, monster);
    }
}



