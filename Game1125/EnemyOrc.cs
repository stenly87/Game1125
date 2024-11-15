using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal class EnemyOrc : Enemy
    {
        public EnemyOrc() 
        {
            Stats.Name = "Орк " + Stats;
            color = ConsoleColor.Yellow;
        }
    }
}
