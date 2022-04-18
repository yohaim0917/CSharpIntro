using System;

namespace CSharp
{
    class Chapter5
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while(true)
            {
                game.Process();
            }
        }
    }
}
