using System;

namespace CSharp
{
    class Chapter1
    {
        // 여기에 주석을 달 수 있어요
        static void Main(string[] args)
        {
            //// 데이터 + 로직
            //// 체력 0

            //// byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            //// sbyte(1바이트 -128~127), ushort(2바이트 0~6.5만), uint(4바이트 0~43억), ulong(8바이트)
            //int hp;
            //short level = 100;
            //long id;
            //hp = 100;

            //byte attack = 0;
            //attack--;

            //// 여기에 주석을 달 수 있어요
            //Console.WriteLine("Hello Number ! {0}", attack);

            //bool b; // 1바이트 : 바이트 연산이 속도가 더 빨라서
            //b = true;
            //b = false;

            //// 소수
            //float f = 3.14f; // 4바이트
            //double d = 3.14; // 8바이트

            //char c = 'a'; // c#에서는 2바이트!!
            //string str = "Hello World";

            //Console.WriteLine(str);

            //int a = 1000;
            //short sh = (short)a;

            int hp = 100;
            int level = 50;

            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);

            // a = 살아있는 고렙 유저 인가요?
            bool a = isAlive && isHighLevel;

            // b = 살아있거나, 고렙 유저이거나, 둘 중 하나인가요?
            bool b = isAlive || isHighLevel;

            // c = 죽은 유저인가요?
            bool c = !isAlive;


            int id = 123;
            int key = 804; // xor 두번하면 원래 값이 나온다

            uint num = 8;

            // << >> &(and) |(or) ^(xor:두 값이 다를때 1) ~(not)
            num = num << 1;


            
        }
    }
}
