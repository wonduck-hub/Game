using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Human
	{
		private String name;
		private int life = 100;
		private int power = 10;
		private int defense = 5;

		public Human(string name)
		{
			this.name = name;
		}

		public void attack(Human enemy)
		{
			enemy.life -= this.power - enemy.defense;
		}
	}
}
