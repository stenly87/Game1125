using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal abstract class CreatureAction
    {
        public string Title { get; set; }
        public abstract void Run(Creature actor, Room room);
    }
}
