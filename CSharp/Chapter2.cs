using System;

namespace CSharp
{
    class Chapter2
    {
        //enum Choice
        //{
        //    ROCK = 1,
        //    PAPER = 2,
        //    SCISSORS = 0
        //}

        //static void HelloWorld()
        //{
        //    Console.WriteLine("Hello World");
        //}

        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        static int Add(int a, int b, int c = 0) // 선택적 매개변수
        {
            Console.WriteLine("Add float 호출");
            return a + b + c;
        }

        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static int AddOne2(int number)
        {
            return number + 1;
        }

        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            
        }

        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }

        static int Factorial(int n)
        {
            //if (n==1)
            //{
            //    return 1;
            //}
            //return Factorial(n - 1) * n;

            int ret = 1;

            for (int num = 1; num <= n; num++)
            {
                ret *= num;
            }

            return ret;
        }

        static void Main(string[] args)
        {

            //int hp = 10;
            //bool isDead = (hp <= 0);

            //if (isDead)
            //{
            //    Console.WriteLine("You are dead!");
            //}
            //else
            //{
            //    Console.WriteLine("You are alive!");
            //}

            //int choice = 0; // 0:가위 1:바위 2:보

            //switch (choice)
            //{
            //    case 0:
            //        Console.WriteLine("가위입니다.");
            //        break;
            //    case 1:
            //        Console.WriteLine("바위입니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("보입니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("치트키입니다.");
            //        break;
            //    default:
            //        Console.WriteLine("다 실패했습니다.");
            //        break;
            //}

            //if (choice == 0)
            //{
            //    Console.WriteLine("가위입니다.");
            //}               
            //else if (choice == 1)
            //{
            //    Console.WriteLine("바위입니다.");
            //}
            //else if (choice == 2)
            //{
            //    Console.WriteLine("보입니다.");
            //}
            //else
            //{                
            //    Console.WriteLine("치트키입니다.");
            //}


            //// 삼항연산자
            //int number = 25;
            //bool isPair = (number % 2 == 0 ? true : false);

            //const int ROCK = 1;
            //const int PAPER = 2;
            //const int SCISSORS = 0;

            //Random rand = new Random();
            //int aiChoice = rand.Next(0, 3); // 0~2사이의 랜덤 값
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch(choice)
            //{
            //    case (int)Choice.SCISSORS:
            //        Console.WriteLine("당신의 선택은 가위입니다.");
            //        break;
            //    case (int)Choice.ROCK:
            //        Console.WriteLine("당신의 선택은 바위입니다.");
            //        break;
            //    case (int)Choice.PAPER:
            //        Console.WriteLine("당신의 선택은 보입니다.");
            //        break;
            //}

            //switch (aiChoice)
            //{
            //    case (int)Choice.SCISSORS:
            //        Console.WriteLine("컴퓨터의 선택은 가위입니다.");
            //        break;
            //    case (int)Choice.ROCK:
            //        Console.WriteLine("컴퓨터의 선택은 바위입니다.");
            //        break;
            //    case (int)Choice.PAPER:
            //        Console.WriteLine("컴퓨터의 선택은 보입니다.");
            //        break;
            //}

            //if(choice == 0)
            //{
            //    if(aiChoice == 0)
            //    {

            //    }

            //}


            //// while 반복문
            //int count = 5;
            //while (count > 0)
            //{
            //    Console.WriteLine("Hello World");
            //    count--;
            //}

            //string answer;
            //do
            //{
            //    Console.WriteLine("강사님은 잘생기셨나요? (y/n) : ");
            //    answer = Console.ReadLine();
            //} while (answer != "y");

            //Console.WriteLine("정답입니다!");

            //int num = 97; // 1, 97로만 나뉘는 숫자 : 소수
            //bool isPrime = true;

            //for (int i = 2; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}

            //if (isPrime)
            //    Console.WriteLine("소수입니다!");
            //else
            //    Console.WriteLine("소수가 아닙니다!");


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 != 0)
            //        continue;

            //    Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
            //}

            //Chapter2.HelloWorld();

            //int a = 4;
            //int b = 5;
            //int result = Chapter2.Add(a, b);
            //Console.WriteLine(result);

            //int a = 0;
            //Chapter2.AddOne(ref a);
            //Console.WriteLine(a);

            //a = Chapter2.AddOne2(a); // 이 버전이 훨씬 좋다
            //Console.WriteLine(a);

            //int num1 = 1;
            //int num2 = 2;
            //Chapter2.swap(ref num1, ref num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //int num1 = 10;
            //int num2 = 3;

            //int result1;
            //int result2;
            //Divide(num1, num2, out result1, out result2);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            // 오버로딩 : 함수 이름의 재사용

            //int ret = Chapter2.Add(2, 3);
            //Console.WriteLine(ret);
            //float ret2 = Chapter2.Add(2.0f, 3.0f);
            //Console.WriteLine(ret2);

            //Chapter2.Add(1, 2, c:2);

            // 연습문제
            //for (int i = 2; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int ret = Factorial(5);
            Console.WriteLine(ret);

        }        
    }
}
