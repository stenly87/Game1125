using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal class Player : Creature
    {
        public Player(string name)
        {
            color = ConsoleColor.Green;
            Console.WriteLine("Выбор класса!");
            Console.WriteLine("1 - воин!");
            Console.WriteLine("2 - маг!");
            string str = Console.ReadLine();
            if (str == "1")
                Stats = new Warrior();
            else
                Stats = new Mage();
            Stats.Name = name;
        }

        public override void RunAction(Room room)
        {
            Console.ForegroundColor = color;
            if (IsDead)
                return;
            Console.WriteLine($"Ваш ход!");
            Stats.PrintActions();
            Console.WriteLine($"Ваше здоровье: {Stats.CurrentHP}/{Stats.MaxHP} ");
            int.TryParse(Console.ReadLine(), out int index);
            index--;
            if (index < 0)
                index = 0;
            if (Stats.Actions.Count < index + 1)
                index = 0;
            CreatureAction action = Stats.Actions[index];
            Console.WriteLine($"Выбрано действие: {action.Title}");
            action.Run(this, room);
        }
    }
}
