using System;
using System.Collections.Generic;

namespace CSharp
{
    class Map
    {
        int[,] tiles =
        {
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 }
        };

        public void Render()
        {
            var defaultColor = Console.ForegroundColor;
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[y, x] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = defaultColor;
        }

    }

    class Monster
    {
        public int id;

        public Monster(int id)
        {
            this.id = id;
        }
        
    }

    class Chapter6
    {
        static int GetHighestScore(int[] scores)
        {
            int highest = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (highest < scores[i])
                {
                    highest = scores[i];
                }
            }

            return highest;
        }

        static int GetAverageScore(int[] scores)
        {
            int sum = 0, average;           
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            average = sum / scores.Length;

            return average;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Sort(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[i] > scores[j])
                    {
                        int temp;
                        temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            //// 배열
            //int[] scores = new int[5] { 10, 20, 30, 40, 50 };
            //int[] scores2 = scores;

            //scores2[0] = 9999;

            //// 0 1 2 3 4
            ////scores[0] = 10;
            ////scores[1] = 20;
            ////scores[2] = 30;
            ////scores[3] = 40;
            ////scores[4] = 50;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //foreach (int score in scores)
            //{
            //    Console.WriteLine(score);
            //}

            //int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            ////Console.WriteLine(GetHighestScore(scores));

            //int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3 } };

            //arr[0, 0] = 1;
            //arr[1, 0] = 1;

            //Map map = new Map();
            //map.Render();

            //int[][] a = new int[3][];
            //a[0] = new int[3];
            //a[1] = new int[6];
            //a[2] = new int[2];



            int[] arr = new int[10];

            // List <- 동적 배열
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            // 삽입 삭제
            list.Insert(2, 999);

            list.RemoveAt(0);
            bool success = list.Remove(999);

            // 전체삭제
            list.Clear();


            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            foreach (int num in list)
                Console.WriteLine(num);


            // Hashtable
            // 아주 큰 박스 [    . .   ..   .   .  ] 1만개 (1 ~ 1만)
            // 박스 여러개를 쪼개 놓는다 [1~10] [11~20] [ ] [ ] [ ] 1천개
            // 7777번 공? -> 777번째 상자
            // 메모리를 내주고 성능을 취한다 !

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            bool found = dic.TryGetValue(20000, out mon);

            dic.Remove(7777);
            dic.Clear();

        }
    }
}
