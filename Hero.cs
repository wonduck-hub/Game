using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Hero : Human
	{
		private string _img;
		private const string _skillName1 = "double attack";
		private const string _skillName2 = "surprise attack";

		public string img
		{
			get { return _img; }
			set { _img = value; }
		}

		public string skillName1
		{
			get { return _skillName1; }
		}

		public string skillName2
		{
			get { return _skillName2; }
		}

		public Hero(int life, int power, int defense, string img) : base(life, power, defense)
		{
			this.name = "왕중량";
			this.img = img;
		}
		public override void attack(Human enemy)
		{
			enemy.life -= power - enemy.defense;
		}	

		public void doubleAttack(Human enemy)
		{
			enemy.life -= (power - enemy.defense) * 2;
		}

	}
}
