// See https://aka.ms/new-console-template for more information
using System;
using TextRPG;



Console.WriteLine("클래스를 선택하세요.");
Console.WriteLine("1. 마법사");
Console.WriteLine("2. 전사");
Console.WriteLine("3. 궁수");

var character = Console.ReadLine();

Player player;

switch(character)
{
    case "1":
        {
            Console.WriteLine("마법사 선택");
            player = new Wizard();
            Random random = new Random();
            player.hp = random.Next(0, 10);
            player.mp = random.Next(0, 10);
        }
        break;
    case "2":
        {
            Console.WriteLine("전사 선택");
            player = new Warrior();
            Random random = new Random();
            player.hp = random.Next(0, 10);
            player.mp = random.Next(0, 10);

        }
        break;
    case "3":
        {
            Console.WriteLine("궁수 선택");
            player = new Archer();
            Random random = new Random();
            player.hp = random.Next(0, 10);
            player.mp = random.Next(0, 10);

        }
        break;
}

Console.Clear();

Console.WriteLine("무엇을 하시겠습니까?");
Console.WriteLine("1. 사냥하기");
Console.WriteLine("2. 쉬기");
;

var action = Console.ReadLine();

switch(action)
{
    case "1":
        {
            Console.WriteLine("사냥하기");

            Monster monster = new Slime();
            Random random = new Random();
            monster.hp = random.Next(0, 10);

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
            player.hp -= random.Next(0, 5);
        }

        public void Defense()
        {

        }
    }

    public class Slime : Monster
    {


        void Attack()
        {
            base.Attack(player: new Player());
        }
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

        public void Attack()
        {

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
            base.Attack();
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
            base.Attack();
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
            base.Attack();
        }

        void Defense()
        {
            base.Defense();
        }
    }
}
