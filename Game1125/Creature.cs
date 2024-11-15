using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal abstract class Creature
    {
        protected ConsoleColor color;
        public CreatureClass Stats { get; set; }
        public bool IsDead { get; set; }
        public void TakeDamage(int damage)
        {
            Stats.TakeDamage(damage);
            if (Stats.CurrentHP <= 0)
                Death();
        }

        void Death()
        {
            Console.WriteLine($"{Stats.Name} сдох!");
            IsDead = true;
        }

        public abstract void RunAction(Room room);

        public void RandomSpeed()
        { 
            Random random = new Random();
            Stats.Speed = random.Next(1, 10);
        }
    }
}
