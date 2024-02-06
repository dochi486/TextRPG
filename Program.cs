﻿// See https://aka.ms/new-console-template for more information

using TextRPG;
using TextRPG.Dialogues.Player;
using TextRPG.Stage;

PlayerDialogues.PlayerClassSelect();

var character = Console.ReadLine();


var initHp = Util.GetRandom(10);
var initMp = Util.GetRandom(10);
var initStr = Util.GetRandom(10);
var initDex = Util.GetRandom(10);
var initMagic = Util.GetRandom(10);
var initDamage = Util.GetRandom(10);

Player player = new Player("플레이어", initHp,initMp,initStr,initDex,initMagic,initDamage);


switch(character)
{
    case "1":
        {
            Console.WriteLine("마법사 선택");
            player = new Wizard("마법사", initHp, initMp, initStr, initDex, initMagic, initDamage);
            Console.WriteLine($"당신의 체력은 : {player.Stat.Hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.Stat.Mp}입니다.");

        }
        break;
    case "2":
        {
            Console.WriteLine("전사 선택");
            player = new Warrior("전사", initHp, initMp, initStr, initDex, initMagic, initDamage);
            Console.WriteLine($"당신의 체력은 : {player.Stat.Hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.Stat.Mp}입니다.");
        }
        break;
    case "3":
        {
            Console.WriteLine("궁수 선택");
            player = new Archer("궁수", initHp, initMp, initStr, initDex, initMagic, initDamage);
            Console.WriteLine($"당신의 체력은 : {player.Stat.Hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.Stat.Mp}입니다.");
        }
        break;
}


Console.WriteLine("무엇을 하시겠습니까?");
Console.WriteLine("1. 사냥하기");
Console.WriteLine("2. 쉬기");

var action = Console.ReadLine();

switch (action)
{
    case "1":
    {
            var slimeHp = Util.GetRandom(10);
            var slimeMp = Util.GetRandom(10);
            var slimeDamage = Util.GetRandom(10);
            Console.WriteLine("사냥하기");
            Monster slime = new Slime("슬라임", slimeHp, slimeMp, slimeDamage);
            Console.WriteLine($"몬스터 {nameof(slime)}가 나타났습니다!");
            Console.WriteLine($"{nameof(slime)}의 체력은 {slime.Stat.Hp}입니다.");

            Stage.BattleSelectDialogue();

            var playerAction = Console.ReadLine();

            switch (playerAction)
            {
                case "1":
                    {
                        while(slime.Stat.Hp > 0)
                        {
                            var damage = slime.GetDamage();
                            player.Attack(damage);
                            
                            if(player.Stat.Hp <= 0)
                            {
                                Console.WriteLine("플레이어 사망");
                                Console.WriteLine("The End");
                                break;
                            }

                            var playerDamage = player.GetDamage();                         
                            slime.Attack(playerDamage);
                            if(slime.Stat.Hp <= 0)
                            {
                                Console.WriteLine($"{nameof(slime)}을 처치하고 경험치를 얻었습니다.");
                                player.Stat.Hp += 10;
                                Console.WriteLine($"당신의 체력이 10만큼 올랐습니다.");

                                Console.WriteLine("슬라임을 처치했습니다. 무엇을 하시겠습니까?");
                                Console.WriteLine("1. 사냥하기");
                                Console.WriteLine("2. 쉬기");
                                break;
                            }
                        }
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("당신은 사냥터에서 도망쳐서 영원히 패배자로 낙인이 찍혔습니다.");
                        Console.WriteLine("The End");
                    }
                    break;
            }
        } 
        break;
    case "2":
        {
            Console.WriteLine("쉬기");
            Console.WriteLine("당신은 영원히 잠들었습니다.");
            Console.WriteLine("The End");
        }
        break;
}


var secondAction = Console.ReadLine();

switch(secondAction)
{
    case "1":
        {
            Console.WriteLine("사냥하기");
            var orcHp = Util.GetRandom(10);
            var orcMp = Util.GetRandom(10);
            var orcDamage = Util.GetRandom(10);
            Monster orc = new Orc("오크", orcHp, orcMp, orcDamage);
            Console.WriteLine($"몬스터 {nameof(orc)}가 나타났습니다!");
            Console.WriteLine($"{nameof(orc)}의 체력은 {orc.Stat.Hp}입니다.");

            Stage.BattleSelectDialogue();

            var playerAction = Console.ReadLine();

            switch(playerAction)
            {
                case "1":
                    {
                        while(orc.Stat.Hp > 0)
                        {
                            var damage = orc.GetDamage();
                            player.Attack(damage);
                            
                            if(player.Stat.Hp <= 0)
                            {
                                Console.WriteLine("플레이어 사망");
                                Console.WriteLine("The End");
                                break;
                            }

                            var playerDamage = player.GetDamage();
                            orc.Attack(playerDamage);
                            
                            if(orc.Stat.Hp <= 0)
                            {
                                Console.WriteLine($"{nameof(orc)}을 처치하고 경험치를 얻었습니다.");
                                player.Stat.Hp += 10;
                                Console.WriteLine($"당신의 체력이 10만큼 올랐습니다.");

                                Console.WriteLine("오크를 처치했습니다. 무엇을 하시겠습니까?");
                                Console.WriteLine("1. 사냥하기");
                                Console.WriteLine("2. 쉬기");
                                break;
                            }
                            
                        }
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("당신은 사냥터에서 도망쳐서 영원히 패배자로 낙인이 찍혔습니다.");
                        Console.WriteLine("The End");
                    }
                    break;
            }
        }
        break;
    case "2":
        {
            Console.WriteLine("쉬기");
            Console.WriteLine("당신은 영원히 잠들었습니다.");
            Console.WriteLine("The End");
        }
        break;
}


var thirdAction = Console.ReadLine();

switch(thirdAction)
{
    case "1":
        {
            Console.WriteLine("사냥하기");
            var goblinHp = Util.GetRandom(10);
            var goblinMp = Util.GetRandom(10);
            var goblinDamage = Util.GetRandom(10);
            Monster goblin = new Goblin("고블린", goblinHp, goblinMp, goblinDamage);
            Console.WriteLine($"몬스터 {nameof(goblin)}가 나타났습니다!");
            Console.WriteLine($"{nameof(goblin)}의 체력은 {goblin.Stat.Hp}입니다.");

            Stage.BattleSelectDialogue();

            var playerAction = Console.ReadLine();

            switch(playerAction)
            {
                case "1":
                    {
                        while(goblin.Stat.Hp > 0)
                        {
                            var damage = goblin.GetDamage();
                            player.Attack(damage);
                            
                            if(player.Stat.Hp <= 0)
                            {
                                Console.WriteLine("플레이어 사망");
                                Console.WriteLine("The End");
                                break;
                            }

                            var playerDamage = player.GetDamage();
                            goblin.Attack(playerDamage);
                            if(goblin.Stat.Hp <= 0)
                            {
                                Console.WriteLine($"{nameof(goblin)}을 처치하고 경험치를 얻었습니다.");
                                player.Stat.Hp += 10;
                                Console.WriteLine($"당신의 체력이 10만큼 올랐습니다.");

                                Console.WriteLine("고블린을 처치했습니다. 여행이 끝났습니다.");
                                break;
                            }
                            
                        }
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("당신은 사냥터에서 도망쳐서 영원히 패배자로 낙인이 찍혔습니다.");
                        Console.WriteLine("The End");
                    }
                    break;
            }
        }
        break;
    case "2":
        {
            Console.WriteLine("쉬기");
            Console.WriteLine("당신은 영원히 잠들었습니다.");
            Console.WriteLine("The End");
        }
        break;
}

namespace TextRPG
{
    public static class Util
    {
        public static int GetRandom(int max) => new Random().Next(1, max);
    }
}

