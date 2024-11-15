using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal class MultiAttackTarget : AttackAllTarget
    {
        public MultiAttackTarget()
        {
            Title = "Атака по группе";
        }
        public override void Run(Creature actor, Room room)
        {
            Random random = new Random();
            List<Creature> targets = new List<Creature>();
            if (actor is Player)
                targets.AddRange(room.Enemies);
            else
                targets.Add(room.Player);
            foreach (var target in targets)
            {
                int dmg = random.Next(1, 3);
                Console.WriteLine($"{actor.Stats.Name} атакует {target.Stats.Name} с уроном {dmg}" + "");
                target.TakeDamage(dmg);
            }
        }
    }
}
