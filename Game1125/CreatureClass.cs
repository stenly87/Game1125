using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal abstract class CreatureClass
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Speed { get; set; }

        public List<CreatureAction> Actions { get; set; }

        internal void TakeDamage(int damage)
        {
            damage -= Armor;
            Console.WriteLine($"Броня {Name} поглощает урон. Урон снижен до {damage}.");
            if ( (damage <= 0))
            {
                Console.WriteLine("Урон не нанесен");
                return;
            }
            CurrentHP -= damage;
        }

        public void PrintActions()
        {
            int index = 1;
            foreach (CreatureAction action in Actions)
                Console.WriteLine($"{index++}) {action.Title}");
            

        }
    }
}
