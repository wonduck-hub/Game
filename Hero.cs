using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Hero : Human
	{
		private Weapon weapon;
		public Hero(int life, int power, int defense, Weapon weapon) : base(life, power, defense)
		{
			this.weapon = weapon;
		}
		public new void Attack(Human enemy)
		{
			switch (weapon)
			{
				case Weapon.SWORD:
					enemy.life -= (this.power + 5) - enemy.defense;
					break;
				case Weapon.BOW:
					enemy.life -= (this.power + 5) - enemy.defense;
					break;
				case Weapon.DAGGER:
					enemy.life -= (this.power + 5) - enemy.defense;
					break;
				case Weapon.SPEAR:
					enemy.life -= (this.power + 5) - enemy.defense;
					break;
			}
		}
	}
}
