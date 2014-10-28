using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRPG
{
    abstract class Spell
    {
        public int Range { get; set; }
        public int Damage { get; set; }

        public Spell(int range, int damage)
        {
            Range = range;
            Damage = damage;
        }

        public abstract void Cast();
    }
}
