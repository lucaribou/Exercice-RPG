using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            Hero hero = new Hero(name);
        }
    }
}
