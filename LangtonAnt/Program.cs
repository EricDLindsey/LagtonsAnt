using System;

namespace LangtonAnt
{
	class Program
	{
		public static void Main()
		{
			Game game = new Game(40, 20);
			Console.WriteLine(game.ToString());

			int g = 1;
			Console.WriteLine("Steps: " + (g++) + ". Press Enter for next step or 'q' to quit.");

			while(Console.ReadLine() != "q")
			{
				Console.Clear();
				game.Tick();
				Console.WriteLine(game.ToString());
				Console.WriteLine("Steps: " + (g++) + ". Press Enter for next step or 'q' to quit.");
			}
		}
	}
}