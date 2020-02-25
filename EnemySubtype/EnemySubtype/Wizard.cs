using System;
using System.Collections.Generic;
using System.Text;

namespace EnemySubtype
{
    class Wizard : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Attack from Wizard.");
        }
    }
}
