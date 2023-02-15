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
			reset(hero, enemy);
		}

		private void reset(Hero hero, Enemy enemy)
		{
			this.Size = new System.Drawing.Size(1200, 800);
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Name = "DuckGame";
			this.Text = "DuckGame";

			this.enemy = enemy;
			this.hero = hero;

			//hero
			this.nameBox.Text = "용사 : " + hero.name;

			this.lifeBar.BackColor = System.Drawing.Color.Green;
			this.lifeBar.Size = new System.Drawing.Size(this.hero.life, PICTUREHEIGHT);

			this.lifeLabel.Text = "hp : " + hero.life.ToString() + "%";

			this.powerBox.ReadOnly = true;
			this.powerBox.Text = hero.power.ToString();
			this.powerLabel.Text = "power : ";

			this.defenseBox.ReadOnly = true;
			this.defenseBox.Text = hero.defense.ToString();
			this.defenseLabel.Text = "defense : ";

			this.heroPicture.Load(hero.img);

			this.attackRadioButton.Text = "attack";
			this.attackRadioButton.Checked = true;

			this.defenseRadioButton.Text = "defense";

			this.dubbleAttackRadioButton.Text = "dubble attack";

			//enemy
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
			if (this.attackRadioButton.Checked)
			{
				heroAttack();
				enemyAttack();
				applyLife();
				showAllStatus();
				checkWinLoss();
			} else if (this.defenseRadioButton.Checked)
			{
				heroDefense();
				applyLife();
				showAllStatus();
				checkWinLoss();
			} else if (this.dubbleAttackRadioButton.Checked)
			{
				heroDoubleAttack();
				enemyAttack();
				applyLife();
				showAllStatus();
				checkWinLoss();
			}

			this.textBox.Text += System.Environment.NewLine;
		}

		private void heroAttack()
		{
			this.textBox.Text += this.hero.name + "이 " + this.enemy.name + "을 정의롭게 공격!";
			this.textBox.Text += System.Environment.NewLine;
			hero.attack(enemy);
		}

		private void heroDoubleAttack()
		{
			this.textBox.Text += this.hero.name + "이 " + this.enemy.name + "에게 이중 공격을 가했다!";
			this.textBox.Text += System.Environment.NewLine;
			hero.doubleAttack(enemy);
		}

		private void heroDefense()
		{
			this.textBox.Text += this.hero.name + "이 " + this.enemy.name + "의 비열한 공격을 정의롭게 막았다!";
			this.textBox.Text += System.Environment.NewLine;
		}

		private void enemyAttack()
		{
			this.textBox.Text += this.enemy.name + "이 " + this.hero.name + "을 비열하게 공격!";
			this.textBox.Text += System.Environment.NewLine;
			enemy.attack(hero);
		}

		private void showAllStatus()
		{
			this.textBox.Text += this.hero.name + "의 hp : " + this.hero.life.ToString();
			this.textBox.Text += System.Environment.NewLine;
			this.textBox.Text += this.enemy.name + "의 hp : " + this.enemy.life.ToString();
			this.textBox.Text += System.Environment.NewLine;
		}

		private void applyLife()
		{
			this.lifeBar.Size = new System.Drawing.Size(this.hero.life, PICTUREHEIGHT);
			this.lifeLabel.Text = "hp : " + hero.life.ToString() + "%";
			this.enemyLifeBar.Size = new System.Drawing.Size(this.enemy.life, PICTUREHEIGHT);
			this.enemyLifeLabel.Text = "hp : " + enemy.life.ToString() + "%";
		}

		private void checkWinLoss()
		{
			if(this.enemy.life <= 0)
			{
				if(MessageBox.Show("악당 " + this.enemy.name + "을 죽였다!\n다시 할건가?", "승리", MessageBoxButtons.YesNo) 
					== DialogResult.Yes)
				{
					reset(new Hero(100, 10, 5, Weapon.SWORD, "middle.png"), new Enemy(100, 8, 3, "gan.png"));
					applyLife();
				} else
				{
					Application.Exit();
				};

			} else if(this.hero.life <= 0)
			{
				if(MessageBox.Show("용사 " + this.hero.name + "가 죽었다!\n다시 할건가?", "패배", MessageBoxButtons.YesNo) 
					== DialogResult.Yes)
				{
					reset(new Hero(100, 10, 5, Weapon.SWORD, "middle.png"), new Enemy(100, 8, 3, "gan.png"));
					applyLife();
				} else
				{
					Application.Exit();
				};
			}
		}

	}
}