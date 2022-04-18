using System;

namespace CSharp
{
    // 절차지향 (함수로 로직을 구성, 함수의 순서 중요, 크기가 커지면 유지보수 어렵) 
    // 객체지향 (OOP : Object Oriented Programming) 은닉성/상속성/다형성

    // Knight
    // 속성 : hp, attack, pos
    // 기능 : Move, Attack, Die

    //class Player   // 부모 클래스 혹은 기반 클래스
    //{
    //    // 필드
    //    static public int counter = 1; // 오로지 1개만 존재!
    //    public int id;
    //    public int hp;
    //    public int attack;

    //    public Player()
    //    {
    //        Console.WriteLine("Player 생성자 호출!");
    //    }

    //    public Player(int hp)
    //    {
    //        this.hp = hp;
    //        Console.WriteLine("Player hp 생성자 호출!");
    //    }

    //    public void Move()
    //    {
    //        Console.WriteLine("Knight Move");
    //    }
    //    public void Attack()
    //    {
    //        Console.WriteLine("Knight Attack");
    //    }
    //}

    //class Mage : Player   // 자식 클래스 혹은 파생 클래스
    //{

    //}

    //class Archer : Player
    //{

    //}

    //class Knight : Player
    //{

    //    int c;

    //    static public void Test()
    //    {
    //        counter++;
    //    }

    //    static public Knight CreateKnight()
    //    {
    //        Knight knight = new Knight();
    //        knight.hp = 100;
    //        knight.attack = 1;
    //        return knight;
    //    }

    //    public Knight() : base(100)
    //    {
    //        //id = counter;
    //        //counter++;

    //        //hp = 100;
    //        //attack = 10;

    //        this.c = 10;
    //        base.hp = 100;
    //        Console.WriteLine("생성자 호출!");


    //        // 접근 한정자
    //        // public protected private

    //        //public int hp;
    //        //private int hp;

    //    }

    //    //public Knight(int hp) : this()
    //    //{
    //    //    this.hp = hp;
    //    //    Console.WriteLine("int 생성자 호출!");
    //    //}
    //    //public Knight(int hp, int attack) : this(hp)
    //    //{
    //    //    this.hp = hp;
    //    //    this.attack = attack;
    //    //    Console.WriteLine("int 생성자 호출!");
    //    //}

    //    //public Knight Clone()
    //    //{
    //    //    Knight knight = new Knight();
    //    //    knight.hp = hp;
    //    //    knight.attack = attack;
    //    //    return knight;
    //    //}

       
    //}

    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    // 오버로딩(함수 이름의 재사용) VS 오버라이딩(다형성을 이용)
    class Knight : Player
    {
        public override void Move()
        {
            base.Move();

            Console.WriteLine("Knight 이동!");
        }
    }

    class SuperKnight : Knight
    {
        public override void Move()
        {
            Console.WriteLine("SuperKnight");
        }
    }

    class Mage : Player
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    class Chapter4
    {      
        static void EnterGame(Player player)
        {
            player.Move();

            //bool isMage = (player is Mage);            
            //if (isMage)
            //{
            //    Mage mage = (Mage)player;
            //    mage.mp = 10;
            //}

            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
                //mage.Move();
            }

            Knight knight = (player as Knight);
            if(knight != null)
            {
                //knight.Move();
            }
        }

        static void Main(string[] args)
        {
            //Knight knight = new Knight();

            //knight.hp = 100;
            //knight.attack = 10;

            //knight.Move();
            //knight.Attack();

            //Knight knight2 = knight.Clone();
            //knight2.hp = 0;

            //Knight knight = new Knight(50, 5);

            //Knight knight = new Knight();

            //Knight knight = Knight.CreateKnight(); // static
            //knight.Move(); // 일반


            Knight knight = new Knight();
            Mage mage = new Mage();

            // Mage 타입 -> Player 타입 (O)
            // Player 타입 -> Mage 타입 (X)
            //Player magePlayer = mage;
            //Mage mage2 = (Mage)magePlayer;

            knight.Move();
            //mage.Move();

            //EnterGame(knight);
            // EnterGame(mage);






            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('P');

            // 2. 변형
            name = name + " Junior";
            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();
            string newName = name.Replace('r', 'l');

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);

        }

    }
}
