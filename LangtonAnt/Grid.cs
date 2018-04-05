using System.Collections.Generic;

namespace LangtonAnt
{
	class Grid
	{
		public Grid(int w, int h)
		{
			Width = w;
			Height = h;
			grid = new HashSet<Cell>();
		}

		private HashSet<Cell> grid;

		public int Width { get; protected set; }
		public int Height { get; protected set; }
		
		public bool this[int x, int y]
		{
			get
			{
				return grid.Contains(x + "," + y);
			}
		}
		
		public bool this[Cell c]
		{
			get
			{
				return grid.Contains(c);
			}
		}
		
		public void Flip(Cell c)
		{
			if(grid.Contains(c))
				grid.Remove(c);
			else
				grid.Add(c);
		}
	}
}