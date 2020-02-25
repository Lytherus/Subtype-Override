using System;
using System.Collections.Generic;
using System.Text;

namespace EnemySubtype
{
    class Viking : Enemy
    {
        public override void Die()
        {
            Console.WriteLine("Die from Viking.");
        }

        public override void Warcry()
        {
            Console.WriteLine("Warcry from Viking.");
        }
    }
}
