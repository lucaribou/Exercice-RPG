using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRPG
{
    class Hero : Character
    {
        public int MagicPower { get; set; }

        public Hero(String name, int magicPower, int healthPoints, int position)
            : base(name, healthPoints, position)
        {
            MagicPower = magicPower;
        }
        public void Move(int distance)
        {

        }
    }
}
