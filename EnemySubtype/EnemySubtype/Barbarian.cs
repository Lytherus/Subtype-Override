using System;
using System.Collections.Generic;
using System.Text;

namespace EnemySubtype
{
    class Barbarian : Enemy
    {
        public override void Choke()
        {
            Console.WriteLine("Choke from barbarian.");
        }
    }
}
