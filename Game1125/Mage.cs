using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal class Mage : CreatureClass
    {
        public Mage()
        {
            CurrentHP = MaxHP = 10;
            Damage = 6;
            Armor = 2;
            Actions = [
                new LightAttackTarget(),
                new MultiAttackTarget()
                ];
        }

        public override string ToString()
        {
            return "Маг";
        }
    }
}
