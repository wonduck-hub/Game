namespace Game
{
	public partial class Form1 : Form
	{
		private Hero _hero;
		private Enemy _enemy;
		const int PICTUREHEIGHT = 23;

		public Hero hero
		{
			get { return _hero; }
			set { _hero = value; }
		}
		public Enemy enemy
		{
			get { return _enemy; }
			set { _enemy = value; }
		}
		public Form1(Hero hero, Enemy enemy)
		{
			InitializeComponent();
			this.Size = new System.Drawing.Size(1200, 800);
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Name = "DuckGame";
			this.Text = "DuckGame";

			//hero
			this.hero = hero;
			this.nameBox.Text = "용사 : " + hero.name;

			this.lifeBar.BackColor = System.Drawing.Color.Green;
			this.lifeBar.Size = new System.Drawing.Size(hero.life, PICTUREHEIGHT);

			this.lifeLabel.Text = "hp : " + hero.life.ToString() + "%";

			this.powerBox.ReadOnly = true;
			this.powerBox.Text = hero.power.ToString();
			this.powerLabel.Text = "power : ";

			this.defenseBox.ReadOnly = true;
			this.defenseBox.Text = hero.defense.ToString();
			this.defenseLabel.Text = "defense : ";

			this.heroPicture.Load(@"middle.png");

			//enemy
			this.enemy = enemy;
			this.enemyNameBox.Text = "악당 : " +  enemy.name;

			this.enemyLifeBar.BackColor = System.Drawing.Color.Red;
			this.enemyLifeBar.Size = new System.Drawing.Size(enemy.life, PICTUREHEIGHT);

			this.enemyLifeLabel.Text = "hp : " + enemy.life.ToString() + "%";

			this.enemyPowerBar.ReadOnly = true;
			this.enemyPowerBar.Text = enemy.power.ToString();
			this.enemyPowerLabel.Text = "power : ";

			this.enemyDefenseBar.ReadOnly = true;
			this.enemyDefenseBar.Text = enemy.defense.ToString();
			this.enemyDefenseLabel.Text = "defense : ";

			this.enemyPicture.Load(@"gan.png");

			//기타
			this.endTurnButton.Text = "End Turn";

			this.textBox.Multiline = true;
			this.textBox.Size = new System.Drawing.Size(650, 650);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void lifeBar_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void endTurnButton_Click(object sender, EventArgs e)
		{
			this.textBox.Text += System.Environment.NewLine;
			heroAttack(hero, enemy);
			enemyAttack(hero, enemy);
			showAllStatus();

			this.textBox.Text += System.Environment.NewLine;
		}

		private void heroAttack(Hero hero, Enemy enemy)
		{
			this.textBox.Text += this.hero.name + "이 " + this.enemy.name + "을 정의롭게 공격!";
			this.textBox.Text += System.Environment.NewLine;
			hero.attack(enemy);
			this.enemyLifeBar.Size = new System.Drawing.Size(this.hero.life, PICTUREHEIGHT);
			this.lifeLabel.Text = "hp : " + hero.life.ToString() + "%";
		}

		private void enemyAttack(Hero hero, Enemy enemy)
		{
			this.textBox.Text += this.enemy.name + "이 " + this.hero.name + "을 비열하게 공격!";
			this.textBox.Text += System.Environment.NewLine;
			enemy.attack(hero);
			this.lifeBar.Size = new System.Drawing.Size(this.hero.life, PICTUREHEIGHT);
			this.enemyLifeLabel.Text = "hp : " + hero.life.ToString() + "%";
		}

		private void showAllStatus()
		{
			this.textBox.Text += this.hero.name + "의 hp : " + this.hero.life.ToString();
			this.textBox.Text += System.Environment.NewLine;
			this.textBox.Text += this.enemy.name + "의 hp : " + this.enemy.life.ToString();
			this.textBox.Text += System.Environment.NewLine;
		}
	}
}