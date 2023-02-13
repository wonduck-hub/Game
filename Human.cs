using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Human
	{
		private String _name;
		private int _life;
		private int _power;
		private int _defense;
		public String name
		{
			get { return "용사 " + _name; }
			set { _name = value; }
		}
		public int life
		{
			get { return _life; }
			set
			{
				if (value <= 0)
				{
					_life = 100;
				}
				else
				{
					_life = value;
				}
			}
		}
		public int power
		{
			get { return _power; }
			set
			{
				if(value <= 0)
				{
					_power = 10;
				}
				else
				{
					_power = value;
				}
			}
		}
		public int defense
		{
			get { return _defense; }
			set
			{
				if(value <= 0)
				{
					_defense = 5;
				}
				else
				{
					_defense = value;
				}
			}
		}

		public Human(int life, int power, int defense)
		{
			this._name = "왕중량";
			this._life = life;
			this._power = power;
			this._defense = defense;
		}

		
		public void Attack(Human enemy)
		{
			enemy.life -= this.power - enemy.defense;
		}
	}
}
