using System;
namespace Hometask
{
	public class Murlock:Hero
	{
		public Murlock()
		{
		}
		public readonly double NightAttack;
		public readonly double NightSpped;
		public Murlock(string name,double attackStrength,double speed)
			:base(name,attackStrength,speed)
		{
			NightAttack = AttackStrength+20;
			NightSpped = Speed + 30;
		}
        public override void Attack()
        {
			if (DateTime.Now.Hour > 18&&DateTime.Now.Hour<6)
			{
                Console.WriteLine($"{Name} is attacking with strength {NightAttack}...");
			}
			else
			{
                Console.WriteLine($"{Name} is attacking with strength {AttackStrength}...");
            }
        }
        public override void Run()
        {
            if (DateTime.Now.Hour > 18 && DateTime.Now.Hour < 6)
            {
                Console.WriteLine($"{Name} is running with speed {NightSpped}...");
            }
            else
            {
                Console.WriteLine($"{Name} is running with speed {Speed}...");
            }
        }
    }
}


//Murlock sinfini tuzing, bu sinfda NightAttack, NightSpeed xusisiyati bo'lsin. 
//Attack metodi kech vaqt bo'lsa "{Name} Attacking with strength {NightAttack}" yozuvini, agar kech vaq bo'lmasa "{Name} attacking with strength {AttackStrength}" yozuvini ekranga chiqarsin.
//Run -> Agar kech vaqt bo'lsa NightSpeed bilan yugursin, kunduz bo'lsa oddiy tezlik bilan.

