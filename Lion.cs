using System;
namespace Hometask
{
	public class Lion:Hero
	{
		public Lion()
		{
		}
		public readonly double NormalHealth=80;
		public Lion(string name, double attackStrength, double speed,double health)
			:base(name,attackStrength,speed,health)
		{
		}
        public override void Run()
        {
			if (Health < NormalHealth)
			{
				Speed = Speed - (Speed * 0.40);

                Console.WriteLine($"{Name} is running with speed {Speed}, because his health is lower than the Normal Helth...");
			}
			else
			{
                Console.WriteLine($"{Name} is running with speed {Speed}...");
            }
        }
    }
}
//Lion sinfini tuzing. bu sinfda NormalHealth xususiyati bo'lsin.
//Run -> metodi agarda Health xususiyati NormalHealthdan past bo'lsa Speed xususiyatidan 40% kam bo'lishi kerak.
