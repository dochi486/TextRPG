// See https://aka.ms/new-console-template for more information

using TextRPG;
using TextRPG.Dialogues.Player;
using TextRPG.Stage;

Dictionary<int, StageInfo> stageInfos = new Dictionary<int, StageInfo>();
StageInfo stage1 = new StageInfo();
stage1.MonsterType = MonsterType.Slime;
stage1.MonsterLevel = 1;
stageInfos.Add(1, stage1);

StageInfo stage2 = new StageInfo();
stage2.MonsterType = MonsterType.Orc;
stage2.MonsterLevel = 2;
stageInfos.Add(2, stage2);

StageInfo stage3 = new StageInfo();
stage3.MonsterType = MonsterType.Goblin;
stage3.MonsterLevel = 3;
stageInfos.Add(3, stage3);
        
while(true)
{
    PlayerDialogues.PlayerClassSelect();

    var character = Console.ReadLine();

    if(character == null)
        character = default;

    var player = Stage.CreateCharacter(character);

    PlayerDialogues.ActionChoose();

    var action = Console.ReadLine();

    for (int i = 1; i <= stageInfos.Count; i++)
    { 
        var monster = MonsterFactory.CreateMonster(stageInfos[i].MonsterType);
        Stage.MonsterBattle(action, player, monster);
    }

}



