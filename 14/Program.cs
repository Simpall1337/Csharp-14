using System;

namespace Lessons
{
    abstract class Weapon
    {
        public abstract void Fire();
        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }
    class Pistol : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("SHOT");
        }
    }
    class Gun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("SHOT");
        }
    }
    class Bow : Weapon
    {
        public override void Fire()
        {

            Console.WriteLine("SHOT");
        }
    }
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
        public void ShowInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] iventory = { new Gun(), new Bow(), new Pistol() };
            foreach (var item in iventory)
            {
                player.ShowInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
        }
    }
}
