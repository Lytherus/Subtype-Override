using System;
using System.Collections.Generic;
using System.Text;

namespace EnemySubtype
{
    class Enemy
    {
        public virtual void Attack()
        {
            Console.WriteLine("Attack from base enemy.");
        }
        
        public virtual void Hide()
        {
            Console.WriteLine("Hide from base enemy.");
        }

        public virtual void Run()
        {
            Console.WriteLine("Run from base enemy.");
        }
        
        public virtual void Die()
        {
            Console.WriteLine("Die from base enemy.");
        }
        public virtual void Warcry()
        {
            Console.WriteLine("Warcry from base enemy.");
        }
        public virtual void Steal()
        {
            Console.WriteLine("Steal from base enemy.");
        }

        public virtual void Choke()
        {
            Console.WriteLine("Choke from base enemy.");
        }
    }
}
