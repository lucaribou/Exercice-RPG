using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRPG
{
    abstract class Character
    {
        public String Name { get; set; }
        public int Position { get; set; }
        public int HealthPoints { get; set; }

        public abstract void Move();

        public Character(String name, int healthPoints, int position)
        {
            Name = name;
            Position = position;
            HealthPoints = healthPoints;
        }
    }
}
