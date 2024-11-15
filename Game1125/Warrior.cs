using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal class Warrior : CreatureClass
    {
        public Warrior()
        {
            CurrentHP = MaxHP = 20;
            Damage = 2;
            Armor = 4;
            Actions = [
                new LightAttackTarget(),
                new MultiAttackTarget()
                ];

        }

        public override string ToString()
        {
            return "Воин";
        }
    }
}
