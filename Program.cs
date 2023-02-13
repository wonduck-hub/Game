namespace Game
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Hero hero = new Hero(100, 10, 5, Weapon.SWORD);
			Enemy enemy = new Enemy(100, 8, 3);
			Application.Run(new Form1(hero, enemy));

		}
	}
}