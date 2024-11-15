using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal abstract class Enemy : Creature
    {
        Random random = new Random();
        public Enemy()
        {
            switch (random.Next(1, 3))
            {
                case 1: Stats = new Warrior(); break;
                case 2: Stats = new Mage(); break;
            }
        }

        public override void RunAction(Room room)
        {
            Console.ForegroundColor = color;
            int index = random.Next(0, Stats.Actions.Count);
            var action = Stats.Actions[index];
            Console.WriteLine($"{Stats.Name} выбрал действие: {action.Title}");
            action.Run(this, room);
        }
    }
}
