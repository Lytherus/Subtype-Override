using System;
using System.Collections.Generic;
using System.Text;

namespace EnemySubtype
{
    class Thief: Enemy
    {
        public override void Hide()
        {
            Console.WriteLine("Hide from thief.");
        }
        public override void Steal()
        {
            Console.WriteLine("Steal from thief.");
        }
    }
}
