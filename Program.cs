// See https://aka.ms/new-console-template for more information

using TextRPG;



Console.WriteLine("클래스를 선택하세요.");
Console.WriteLine("1. 마법사");
Console.WriteLine("2. 전사");
Console.WriteLine("3. 궁수");

var character = Console.ReadLine();

Player player = new Player();

Random rand = new Random();
var initHp = rand.Next(1, 10);
var initMp = rand.Next(1, 10);
var initStr = rand.Next(1, 10);
var initDex = rand.Next(1, 10);
var initMagic = rand.Next(1, 10);
var initDamage = rand.Next(1, 10);

switch (character)
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
            var slimeHp = rand.Next(1, 10);
            var slimeMp = rand.Next(1, 10);
            var slimeDamage = rand.Next(1, 10);
            Console.WriteLine("사냥하기");
            Monster slime = new Slime("슬라임", slimeHp, slimeMp, slimeDamage);
            Console.WriteLine($"몬스터 {nameof(slime)}가 나타났습니다!");
            Console.WriteLine($"{nameof(slime)}의 체력은 {slime.Stat.Hp}입니다.");

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.공격하기");
            Console.WriteLine("2.도망가기");

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
            var orcHp = rand.Next(1, 10);
            var orcMp = rand.Next(1, 10);
            var orcDamage = rand.Next(1, 10);
            Monster orc = new Orc("오크", orcHp, orcMp, orcDamage);
            Console.WriteLine($"몬스터 {nameof(orc)}가 나타났습니다!");
            Console.WriteLine($"{nameof(orc)}의 체력은 {orc.Stat.Hp}입니다.");

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.공격하기");
            Console.WriteLine("2.도망가기");

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
            var goblinHp = rand.Next(1, 10);
            var goblinMp = rand.Next(1, 10);
            var goblinDamage = rand.Next(1, 10);
            Monster goblin = new Goblin("고블린", goblinHp, goblinMp, goblinDamage);
            Console.WriteLine($"몬스터 {nameof(goblin)}가 나타났습니다!");
            Console.WriteLine($"{nameof(goblin)}의 체력은 {goblin.Stat.Hp}입니다.");

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.공격하기");
            Console.WriteLine("2.도망가기");

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
            return random.Next(1, Stat.Damage);
        }
    }


    public class Monster : BattleObject
    {
        public Monster()
        {
            Random random = new Random();
            Stat.Hp = random.Next(1, 10);
            Stat.Mp = random.Next(1, 10);
            Stat.Damage = random.Next(1, 10);
        }

        public Monster(string name, int hp, int mp, int damage) : base(name,
            new BattleObjectStat(hp, mp, 0, 0, 0, initDamage: damage))
        {
            Stat.Hp = hp;
            Stat.Mp = mp;
            Stat.Damage = damage;
        }
    }

    public class Slime : Monster
    {
        public Slime(string name, int initHp, int initMp, int initDamage) : base(name, initHp, initMp, initDamage)
        {

        }
    }

    public class Goblin : Monster
    {
        public Goblin(string name, int initHp, int initMp, int initDamage) : base(name, initHp, initMp, initDamage)
        {

        }
    }

    public class Orc : Monster
    {
        public Orc(string name, int initHp, int initMp, int initDamage) : base(name, initHp, initMp, initDamage)
        {

        }
    }


    public class Player : BattleObject
    {
        public Player()
        {
            Random random = new Random();
            Stat.Hp = random.Next(1, 10);
            Stat.Mp = random.Next(1, 10);
            Stat.Damage = random.Next(1, 10);
        }

        public Player(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage) :
            base(name,
                new BattleObjectStat(initHp, initMp, initStr: initStr, initDex: initDex, initMagic: initMagic,
                    initDamage: initDamage))
        {
            Stat.Hp = initHp;
            Stat.Mp = initMp;
            Stat.Str = initStr;
            Stat.Dex = initDex;
            Stat.Magic = initMagic;
            Stat.Damage = initDamage;
        }

    }

    public class Archer : Player
    {
        public Archer(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage) :
            base(name, initHp, initMp, initStr, initDex, initMagic, initDamage)
        {
            
        }
    }

    public class Warrior : Player
    {
        public Warrior(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage) :
            base(name, initHp, initMp, initStr, initDex, initMagic, initDamage)
        {
            
        }
    }

    public class Wizard : Player
    {
        public Wizard(string name, int initHp, int initMp, int initStr, int initDex, int initMagic, int initDamage) :
            base(name, initHp, initMp, initStr, initDex, initMagic, initDamage)
        {
            
        }
    }
}

