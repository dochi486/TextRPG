// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using TextRPG;



Console.WriteLine("클래스를 선택하세요.");
Console.WriteLine("1. 마법사");
Console.WriteLine("2. 전사");
Console.WriteLine("3. 궁수");

var character = Console.ReadLine();

Player player = new Player();

switch (character)
{
    case "1":
        {
            Console.WriteLine("마법사 선택");
            player = new Wizard();
            Random random = new Random();
            player.hp = random.Next(0, 10);
            player.mp = random.Next(0, 10);
            Console.WriteLine($"당신의 체력은 : {player.hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.mp}입니다.");


        }
        break;
    case "2":
        {
            Console.WriteLine("전사 선택");
            player = new Warrior();
            Random random = new Random();
            player.hp = random.Next(0, 10);
            player.mp = random.Next(0, 10);
            Console.WriteLine($"당신의 체력은 : {player.hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.mp}입니다.");
        }
        break;
    case "3":
        {
            Console.WriteLine("궁수 선택");
            player = new Archer();
            Random random = new Random();
            player.hp = random.Next(0, 10);
            player.mp = random.Next(0, 10);
            Console.WriteLine($"당신의 체력은 : {player.hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.mp}입니다.");
        }
        break;
}


Console.WriteLine("무엇을 하시겠습니까?");
Console.WriteLine("1. 사냥하기");
Console.WriteLine("2. 쉬기"); ;

bool isModeSelected = false;


// 사냥터 모드 선택
while (isModeSelected)
{

}

var action = Console.ReadLine();

switch (action)
{
    case "1":
        {
            Console.WriteLine("사냥하기");

            Monster slime = new Slime();
            Random random = new Random();
            slime.hp = random.Next(0, 10);
            Console.WriteLine($"몬스터 {nameof(slime)}가 나타났습니다!");
            Console.WriteLine($"{nameof(slime)}의 체력은 {slime.hp}입니다.");

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.공격하기");
            Console.WriteLine("2.도망가기");

            var playerAction = Console.ReadLine();

            switch (playerAction)
            {
                case "1":
                    {
                        player.Attack(slime);
                        if (player.hp < 0)
                            Console.WriteLine("플레이어 사망");
                        slime.Attack(player);
                        if (slime.hp < 0)
                            Console.WriteLine($"{nameof(slime)}을 처치하고 경험치를 얻었습니다.");
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


        }
        break;
}

namespace TextRPG
{
    public class Monster
    {
        public int hp { get; set; }

        public void Attack(Player player)
        {
            // 상대방의 체력을 깎는다. 
            Random random = new Random();
            var attack = random.Next(0, 5);
            player.hp -= attack;
            Console.WriteLine($"플레이어에게 {attack}만큼의 대미지를 주었습니다.");
        }

        public void Defense()
        {

        }
    }

    public class Slime : Monster
    {

    }

    public class Goblin : Monster
    {

    }

    public class Orc : Monster
    {

    }


    public class Player
    {
        public int hp { get; set; }
        public int mp { get; set; }

        public void Attack(Monster monster)
        {
            Random random = new Random();
            var attack = random.Next(0, 5);
            monster.hp -= attack;
            Console.WriteLine($"{nameof(monster)}에게 {attack}만큼의 대미지를 주었습니다.");
        }

        public void Defense()
        {

        }
    }

    public class Archer : Player
    {
        public int dex;

        void Attack()
        {
        }

        void Defense()
        {
            base.Defense();
        }
    }
    public class Warrior : Player
    {
        public int str;

        void Attack()
        {
        }

        void Defense()
        {
            base.Defense();
        }
    }
    public class Wizard : Player
    {
        public int magic;

        void Attack()
        {
        }

        void Defense()
        {
            base.Defense();
        }
    }
}

