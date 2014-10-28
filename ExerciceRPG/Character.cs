using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRPG
{
    abstract class Character
    {
        public abstract String Name { get; set; }
        public abstract int HealthPoints { get; set; }
        public abstract int Position { get; set; }
        public abstract void Move();
    }
}
