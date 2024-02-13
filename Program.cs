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

    // 2. while문으로 stage 바꾸기
    // 3. Dictionary나 json으로 스테이지 정보 저장하기? 

    Slime slime = (Slime)Stage.CreateMonster("슬라임");

    Stage.MonsterBattle(action, player, slime);

    var secondAction = Console.ReadLine();

    Orc orc = (Orc)Stage.CreateMonster("오크");

    Stage.MonsterBattle(secondAction, player, orc);


    var thirdAction = Console.ReadLine();

    Goblin goblin = (Goblin)Stage.CreateMonster("고블린");

    Stage.MonsterBattle(thirdAction, player, goblin);
}



