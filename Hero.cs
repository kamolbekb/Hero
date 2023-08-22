using System;
using Hometask;
using System.Xml.Linq;

namespace Hometask
{
	public class Hero
	{
        public Hero()
        {
        }
        public string Name { get; set; }
		public double AttackStrength { get; set; }
		public double Speed { get; set; }
		public double Health { get; set; }
		public Hero(string name)
		{
			Name = name;
		}
		public Hero(string name,double attackStrength)
			: this(name)
		{
			AttackStrength = attackStrength;
		}
        public Hero(string name, double attackStrength,double speed)
            : this(name,attackStrength)
        {
			Speed = speed;
        }
        public Hero(string name, double attackStrength, double speed,double health)
            : this(name, attackStrength,speed)
        {
			Health = health;
        }

        public virtual void Attack()
		{
			Console.WriteLine($"{Name} is attacking with strength {AttackStrength}...");
		}
		public virtual void Run()
		{
            Console.WriteLine($"{Name} is running away...");
        }
		public void Defend()
		{
            Console.WriteLine($"{Name} is defending...");
        }
		public void Display()
		{
			Console.WriteLine($"Name:{Name}\nAttack strength:{AttackStrength}\nSpeed:{Speed}\nHealth:{Health}");
		}
	}
}
//#Homework

//Hero sinfini tuzing.
//Xusisiyatlar: Name, AttackStrength, Speed, Health
//Metodlar: Attack, Run, Defend, Display.
//Attack metodi -> "{Name} Attacking with strength {AttackStrength}" yozuvini ekranga chiqarsin.
//Run -> "{Name} is running"
//Defend -> "{Name} is defending"
//Display -> Barcha xususiyatlrani ekranga chiqarib beradi



