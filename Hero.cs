using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Hero : Human
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
				//TODO 나중에 무기별 공격력 계산하는 함수로 추가
				case Weapon.SWORD:
					enemy.life -= SwordAttackPower() - enemy.defense;
					break;
				case Weapon.BOW:
					break;
				case Weapon.DAGGER:
					break;
				case Weapon.SPEAR:
					break;
			}
		}	
		public int SwordAttackPower()
		{
			return this.power + 5;
		}

	}
}
