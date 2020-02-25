using System;

namespace EnemySubtype
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy w = new Wizard();
            Enemy b = new Boar();
            Enemy t = new Thief();
            Enemy ba = new Barbarian();
            Enemy v = new Viking();
            Enemy e = new Enemy();

            e.Attack();
            e.Hide();
            e.Run();
            e.Die();
            w.Attack();
            b.Run();
            t.Hide();
            v.Die();
            v.Warcry();
            t.Steal();
            ba.Choke();
        }

    }
}
