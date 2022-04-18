using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharp
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Chapter7
    {
        abstract class Monster
        {
            public abstract void Shout();
        }

        interface IFlyable
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("오크오크!");
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("해골해골!");
            }
        }

        class Knight
        {
            //protected int hp;

            //public int Hp
            //{
            //    get { return hp; }
            //    set { hp = value; }
            //}

            //// Getter Get함수
            //public int GetHp() { return hp; }

            //// Setter Set함수
            //public void SetHp(int hp) { this.hp = hp; }

            public int Hp { get; set; }

        }

        delegate int OnClicked(); // 함수가 아니라 형식!
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
        // 반환 : int , 입력 : void
        // OnClicked 이 delegate 형식의 이름이다!


        static void ButtonPressed(/* 함수 자체를 인자로 넘겨주고 */)
        {
            // 함수를 호출();
        }

        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }


        static List<Item> _items = new List<Item>();

        delegate Return MyFunc<T, Return>(T item);

        static Item FindItem(MyFunc<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        class TestException : Exception
        {

        }

        class Important : System.Attribute
        {
            string message;

            public Important(string message)
            {
                this.message = message;
            }
        }

        class Monster2
        {
            // hp입니다. 중요한 정보입니다.
            [Important("Very Important")]
            public int hp;

            protected int attack;
            private float speed;

            void Attack() { }
        }

        static int Find()
        {
            return 0;
        }

        static void Main(string[] args)
        {
            //// 프로퍼티
            //Knight knight = new Knight();
            ////knight.SetHp(100);
            //knight.Hp = 100;
            //int hp = knight.Hp;


            //// delegate (대리자)
            ////OnClicked clicked = new Onclicked(TestDelegate);



            //InputManager inputmanager = new InputManager();
            //inputmanager.InputKey += OnInputTest; // 구독신청

            //while(true)
            //{
            //    inputmanager.Update();
            //}



            //// Lambda : 일회용 함수를 만드는데 사용하는 문법.

            //_items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            //_items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            //_items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            //Func<Item, bool> selector = (Item item) => { return item.ItemType == ItemType.Weapon;

            //// Anonymous Function : 무명 함수 or 익명 함수
            ////Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

            //Item item = FindItem(selector);



            //try
            //{
            //    // 1. 0으로 나눌 때
            //    // 2. 잘못된 메모리를 참조 (null)
            //    // 3. 오버플로우

            //    throw new TestException();
            //}
            //catch (DivideByZeroException e)
            //{

            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{
            //    // DB, 파일 정리 등등
            //}



            //// Reflection : X-Ray
            //Monster2 monster = new Monster2();
            //Type type = monster.GetType();

            //var fields = type.GetFields(System.Reflection.BindingFlags.Public
            //    | System.Reflection.BindingFlags.NonPublic
            //    | System.Reflection.BindingFlags.Static
            //    | System.Reflection.BindingFlags.Instance);

            //foreach (FieldInfo field in fields)
            //{
            //    string access = "protected";
            //    if (field.IsPublic)
            //        access = "public";
            //    else if (field.IsPrivate)
            //        access = "private";

            //    var attributes = field.GetCustomAttributes();

            //    Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            //}



            // Nullable -> Null + able

            int? number = 5;

            //number = 3;

            int b = number ?? 0;

            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

        }
    }
}
