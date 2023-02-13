using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Human
	{
		public String name
		{
			get { return this.name; }
			set { this.name = value; }
		}
		public int life
		{
			get { return this.life; }
			set
			{
				if (value <= 0)
				{
					this.life = 100;
				}
				else
				{
					this.life = value;
				}
			}
		}
		public int power
		{
			get { return this.power; }
			set
			{
				if(value <= 0)
				{
					this.power = 10;
				}
				else
				{
					this.power = value;
				}
			}
		}
		public int defense
		{
			get { return this.defense; }
			set
			{
				if(value <= 0)
				{
					this.defense = 5;
				}
				else
				{
					this.defense = value;
				}
			}
		}

		public Human(int life, int power, int defense)
		{
			this.name = "testHuman";
			this.life = life;
			this.power = power;
			this.defense = defense;
		}

		
		public void Attack(Human enemy)
		{
			enemy.life -= this.power - enemy.defense;
		}
	}
}
