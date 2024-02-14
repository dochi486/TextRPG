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

    // 3. Dictionary나 json으로 스테이지 정보 저장하기? 

    Slime slime = (Slime)MonsterFactory.CreateMonster(MonsterType.Slime);

    Stage.MonsterBattle(action, player, slime);

    var secondAction = Console.ReadLine();

    Orc orc = (Orc)MonsterFactory.CreateMonster(MonsterType.Orc);

    Stage.MonsterBattle(secondAction, player, orc);

    var thirdAction = Console.ReadLine();

    Goblin goblin = (Goblin)MonsterFactory.CreateMonster(MonsterType.Goblin);

    Stage.MonsterBattle(thirdAction, player, goblin);
}



