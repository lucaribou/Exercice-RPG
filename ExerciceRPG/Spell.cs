using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRPG
{
    abstract class Spell
    {
        public abstract int Range { get; set; }
        public abstract int Damage { get; set; }

        public abstract void Cast();
    }
}
