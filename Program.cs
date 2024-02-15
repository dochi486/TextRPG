// See https://aka.ms/new-console-template for more information

using TextRPG;
using TextRPG.Dialogues.Player;
using TextRPG.Stage;

while(true)
{
    PlayerDialogues.PlayerClassSelect();

    var character = Console.ReadLine();

    if(character == null)
        character = default;

    var player = Stage.CreateCharacter(character);

    PlayerDialogues.ActionChoose();

    var action = Console.ReadLine();

    StageInfo stageInfo = new StageInfo();
    
    for (int i = 1; i <= stageInfo.StageDictionary.Count; i++)
    { 
        Monster monster = MonsterFactory.CreateMonster(stageInfo.StageDictionary[i].EMonsterType);
        Stage.MonsterBattle(action, player, monster);
    }
}



