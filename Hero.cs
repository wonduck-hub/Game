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
		private string _img;
		private int experience;

		public string img
		{
			get { return _img; }
			set { _img = value; }
		}

		public Hero(int life, int power, int defense, Weapon weapon, string img) : base(life, power, defense)
		{
			this.weapon = weapon;
			this.name = "왕중량";
			this.img = img;
		}
		public new void attack(Human enemy)
		{
			switch (weapon)
			{

				//TODO 나중에 무기별 공격력 계산하는 함수로 추가
				case Weapon.SWORD:
					enemy.life -= swordAttackPower() - enemy.defense;
					break;
				case Weapon.BOW:
					break;
				case Weapon.DAGGER:
					break;
				case Weapon.SPEAR:
					break;
			}
		}	

		public void doubleAttack(Human enemy)
		{
			switch (weapon)
			{

				//TODO 나중에 무기별 공격력 계산하는 함수로 추가
				case Weapon.SWORD:
					enemy.life -= (swordAttackPower() - enemy.defense) * 2;
					break;
				case Weapon.BOW:
					break;
				case Weapon.DAGGER:
					break;
				case Weapon.SPEAR:
					break;
			}
		}

		private int swordAttackPower()
		{
			return this.power + 5;
		}

	}
}
