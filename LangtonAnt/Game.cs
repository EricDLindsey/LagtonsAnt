using System;

namespace LangtonAnt
{
	class Game
	{
		public Game(int w, int h)
		{
			grid = new Grid(w, h);
			
			Random r = new Random();
			ant = new Ant(r.Next(w), r.Next(h), Ant.GetDir(r.Next(4)));
		}
		
		private Grid grid;
		private Ant ant;
		
		public void Tick()
		{
			Cell a = ant.Cell;
			
			grid.Flip(a);
			
			if(grid[a])
				ant.TurnLeft();
			else
				ant.TurnRight();
			
			switch(ant.Direction)
			{
				case Dir.North:
					ant.Y--;
					if(ant.Y < 0)
						ant.Y = grid.Height - 1;
					break;
				case Dir.East:
					ant.X++;
					ant.X %= grid.Width;
					break;
				case Dir.South:
					ant.Y++;
					ant.Y %= grid.Height;
					break;
				case Dir.West:
					ant.X--;
					if(ant.X < 0)
						ant.X = grid.Width - 1;
					break;
			}
		}
		
		public override string ToString()
		{
			string s = "";

			Cell a = ant.Cell;

			for(int y = 0; y < grid.Height; y++)
			{
				for(int x = 0; x < grid.Width; x++)
				{
					if(x == a.X && y == a.Y)
						s += "a";
					else if(grid[x, y])
						s += "O";
					else
						s += ".";
				}

				s += "\n";
			}

			return s;
		}
	}
}