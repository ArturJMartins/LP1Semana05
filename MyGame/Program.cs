using System;

namespace MyGame
{

    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(String _name)
        {
            // isto nem é necessário por causa da funçao SetName, mas
            // se não tivesse essa funçao terias que colocar this.name
            this.name = _name;

            SetName(_name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void SetName(string _name)
        {
            string newName = "";
            if(_name.Length > 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    newName += _name[i];          
                }
            }
            else
            {
                newName += _name;
            }
            this.name = newName;
        }

        public float GetHealth()
        {
            return this.health;
        }

        public float GetShield()
        {
            return this.shield;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Enemy loki = new Enemy("Loki");
            //loki.SetName("   Grindalokki   ");
            //Console.WriteLine($"Name is {loki.GetName()} and "
            //+ $"HP is {loki.GetHealth()}");

            Enemy[] enemies = new Enemy[int.Parse(args[0])];

            for(int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string enemyName = Console.ReadLine();
                enemies[i] = new Enemy(enemyName);

            }
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()}" +
                 $" {enemy.GetShield()}");
            }
            
        }
    }
}
