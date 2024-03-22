using System;

namespace MyGame
{

    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(String name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
