﻿// See https://aka.ms/new-console-template for more information

using TextRPG;



Console.WriteLine("클래스를 선택하세요.");
Console.WriteLine("1. 마법사");
Console.WriteLine("2. 전사");
Console.WriteLine("3. 궁수");

var character = Console.ReadLine();


Random random = new Random();
int hp = random.Next(1, 10);
int mp = random.Next(1, 10);

Player player = new Player(hp, mp);

switch (character)
{
    case "1":
        {
            Console.WriteLine("마법사 선택");
            player = new Wizard();
            Console.WriteLine($"당신의 체력은 : {player.PlayerStat.Hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.PlayerStat.Mp}입니다.");


        }
        break;
    case "2":
        {
            Console.WriteLine("전사 선택");
            player = new Warrior();
            Console.WriteLine($"당신의 체력은 : {player.PlayerStat.Hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.PlayerStat.Mp}입니다.");
        }
        break;
    case "3":
        {
            Console.WriteLine("궁수 선택");
            player = new Archer();
            Console.WriteLine($"당신의 체력은 : {player.PlayerStat.Hp}입니다.");
            Console.WriteLine($"당신의 마력은 : {player.PlayerStat.Mp}입니다.");
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
            Console.WriteLine("사냥하기");
            Random monsterStat = new Random();

            int monsterHp = monsterStat.Next(1, 10);
            int monsterMp = monsterStat.Next(1, 10);

            Monster slime = new Slime(monsterHp, monsterMp);
            Console.WriteLine($"몬스터 {nameof(slime)}가 나타났습니다!");
            Console.WriteLine($"{nameof(slime)}의 체력은 {slime.MonsterStat.Hp}입니다.");

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.공격하기");
            Console.WriteLine("2.도망가기");

            var playerAction = Console.ReadLine();

            switch (playerAction)
            {
                case "1":
                    {
                        while(slime.MonsterStat.Hp > 0)
                        {
                            var damage = slime.GetDamage();
                            player.Attack(damage);
                            
                            if(player.PlayerStat.Hp <= 0)
                            {
                                Console.WriteLine("플레이어 사망");
                                Console.WriteLine("The End");
                                break;
                            }

                            var playerDamage = player.GetDamage();                         
                            slime.Attack(playerDamage);
                            if(slime.MonsterStat.Hp <= 0)
                            {
                                Console.WriteLine($"{nameof(slime)}을 처치하고 경험치를 얻었습니다.");
                                player.PlayerStat.Hp += 10;
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
            Random secondMonsterStat = new Random();

            int orcHp = secondMonsterStat.Next(1, 10);
            int orcMp = secondMonsterStat.Next(1, 10);

            Monster orc = new Orc(orcHp, orcMp);
            Console.WriteLine($"몬스터 {nameof(orc)}가 나타났습니다!");
            Console.WriteLine($"{nameof(orc)}의 체력은 {orc.MonsterStat.Hp}입니다.");

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.공격하기");
            Console.WriteLine("2.도망가기");

            var playerAction = Console.ReadLine();

            switch(playerAction)
            {
                case "1":
                    {
                        while(orc.MonsterStat.Hp > 0)
                        {
                            var damage = orc.GetDamage();
                            player.Attack(damage);
                            
                            if(player.PlayerStat.Hp <= 0)
                            {
                                Console.WriteLine("플레이어 사망");
                                Console.WriteLine("The End");
                                break;
                            }

                            var playerDamage = player.GetDamage();
                            orc.Attack(playerDamage);
                            
                            if(orc.MonsterStat.Hp <= 0)
                            {
                                Console.WriteLine($"{nameof(orc)}을 처치하고 경험치를 얻었습니다.");
                                player.PlayerStat.Hp += 10;
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
            Random thirdMonsterStat = new Random();

            int goblinHp = thirdMonsterStat.Next(0, 10);
            int goblinMp = thirdMonsterStat.Next(0, 10);

            Monster goblin = new Goblin(goblinHp, goblinMp);
            Console.WriteLine($"몬스터 {nameof(goblin)}가 나타났습니다!");
            Console.WriteLine($"{nameof(goblin)}의 체력은 {goblin.MonsterStat.Hp}입니다.");

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.공격하기");
            Console.WriteLine("2.도망가기");

            var playerAction = Console.ReadLine();

            switch(playerAction)
            {
                case "1":
                    {
                        while(goblin.MonsterStat.Hp > 0)
                        {
                            var damage = goblin.GetDamage();
                            player.Attack(damage);
                            
                            if(player.PlayerStat.Hp <= 0)
                            {
                                Console.WriteLine("플레이어 사망");
                                Console.WriteLine("The End");
                                break;
                            }

                            var playerDamage = player.GetDamage();
                            goblin.Attack(playerDamage);
                            if(goblin.MonsterStat.Hp <= 0)
                            {
                                Console.WriteLine($"{nameof(goblin)}을 처치하고 경험치를 얻었습니다.");
                                player.PlayerStat.Hp += 10;
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
    public class BattleObject()
    {
        public string? Name { get; set; }

        public struct BattleObjectStat(int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage)
        {
            public int Hp { get; set; } = initHp;
            public int Mp { get; set; } = initMp;
            public int Str { get; set; } = initStr;
            public int Dex { get; set; } = initDex;
            public int Magic { get; set; } = initMagic;
            public int Damage { get; set; } = initDamage;
        }

        public BattleObjectStat Stat;
        
        
        public BattleObject(string name, BattleObjectStat stat) : this()
        {
            this.Name = name;
            Stat = stat;
        }

        public void Attack(int damage)
        {
            BattleObjectStat modifiedStat = Stat;
            modifiedStat.Hp -= damage;
            Stat = modifiedStat;
        }

        public int GetDamage()
        { 
            Random random = new Random();
            return random.Next(0, Stat.Damage);
        }
    }
    
    
    public class Monster() : BattleObject
    {
        public BattleObjectStat MonsterStat;
        
        public Monster(int hp, int mp) : this()
        {
            MonsterStat.Hp = hp;
            MonsterStat.Mp = mp;
            Random random = new Random();
            MonsterStat.Damage = random.Next();
        }
    }

    public class Slime(int hp, int mp) : Monster(hp, mp);

    public class Goblin(int hp, int mp) : Monster(hp, mp);

    public class Orc(int hp, int mp) : Monster(hp, mp);


    public class Player() : BattleObject
    {
        public BattleObjectStat PlayerStat;
        
        public Player(int hp, int mp) : this()
        {
            PlayerStat.Hp = hp;
            PlayerStat.Mp = mp;
            Random random = new Random();
            PlayerStat.Damage = random.Next();
        }

    }

    public class Archer : Player;

    public class Warrior : Player;

    public class Wizard : Player;
}

