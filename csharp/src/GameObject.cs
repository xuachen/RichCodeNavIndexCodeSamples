namespace game
{
    class GameObject: Drawable, Interactive
    {
        private int posX, posY;

        public GameObject(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }

        public void interact()
        {
            Console.WriteLine("Interacting with GameObject");
        }

        public void draw()
        {
            Console.WriteLine($"Drawing GameObject at position: {this.posX} {this.posY}");
        }
    }
}