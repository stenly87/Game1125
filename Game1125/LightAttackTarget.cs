using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal class LightAttackTarget : AttackOneTarget
    {
        public LightAttackTarget()
        {
            Title = "Легкая атака";
        }
        public override void Run(Creature actor, Room room)
        {
            Console.WriteLine($"{actor.Stats.Name} выбирает действие: {Title}");
            Random rand = new Random();
            Creature target;
            if (actor is Player)
            {
                int index = 1;
                Console.WriteLine("Выбор врага");
                foreach (var enemy in room.Enemies)
                {
                    Console.WriteLine($"{index++} - {enemy.Stats.Name} hp:{enemy.Stats.CurrentHP}/{enemy.Stats.MaxHP}");
                }
                int.TryParse(Console.ReadLine(), out index);
                if (index < 0)
                    index = 1;
                if (room.Enemies.Count < index)
                    index = 1;
                index--;
                target = room.Enemies[index];
            }
            else
            {
                target = room.Player;
            }
            int dmg = actor.Stats.Damage + rand.Next(1, 6);
            Console.WriteLine($"{actor.Stats.Name} атакует {target.Stats.Name} с уроном {dmg}" + "");
            target.TakeDamage(dmg);
        }
    }
}
