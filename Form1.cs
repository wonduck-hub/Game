namespace Game
{
	public partial class Form1 : Form
	{
		private Hero _hero;
		public Hero hero
		{
			get { return _hero; }
			set { _hero = value; }
		}
		public Form1(Hero hero)
		{
			InitializeComponent();
			this.Size = new System.Drawing.Size(1200, 800);
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;

			this.hero = hero;
			this.nameBox.Text = hero.name;

			this.lifeBar.BackColor = System.Drawing.Color.Green;
			this.lifeBar.Size = new System.Drawing.Size(hero.life, 23);

			this.lifeLabel.Text = "hp : " + hero.life.ToString() + "%";

			this.powerBox.ReadOnly = true;
			this.powerBox.Text = hero.power.ToString();
			this.powerLabel.Text = "power : ";

			this.defenseBox.ReadOnly = true;
			this.defenseBox.Text = hero.defense.ToString();
			this.defenseLabel.Text = "defense : ";

			this.heroPicture.Load(@"middle.png");
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
	}
}