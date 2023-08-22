using System;
namespace Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Lion", 100, 100, 75);
            lion.Run();
            lion.Display();
            Console.WriteLine();
            Murlock murlock = new Murlock("Murlock", 100, 100);
            murlock.Attack();
        }
    }
}
