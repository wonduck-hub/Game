using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Enemy : Human
	{
		private string _img;

		public string img
		{
			get { return _img; }
			set { _img = value; }
		}
		public Enemy(int life, int power, int defense, string img) : base(life, power, defense)
		{
			this.name = "복간준";
			this.img = img;
		}
		public override void attack(Human enemy)
		{
			enemy.life -= this.power - enemy.defense;
		}
	}
}
