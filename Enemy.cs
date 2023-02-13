using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Enemy : Human
	{
		public Enemy(int life, int power, int defense) : base(life, power, defense)
		{
			this.name = "복간준";
		}
		public new void attack(Human enemy)
		{
			enemy.life -= this.power - enemy.defense;
		}
	}
}
