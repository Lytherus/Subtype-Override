using System;
using System.Collections.Generic;
using System.Text;

namespace EnemySubtype
{
    class Boar : Enemy
    {
        public override void Run()
        {
            Console.WriteLine("Run from boar.");
        }
    }
}
