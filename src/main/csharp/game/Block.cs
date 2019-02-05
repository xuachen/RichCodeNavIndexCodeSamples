using System;

namespace game
{
    class Block: GameObject
    {
        public Block(int x, int y): base(x, y){}

        public new void interact()
        {
            Console.WriteLine("You get a coin!");
        }
    }
}