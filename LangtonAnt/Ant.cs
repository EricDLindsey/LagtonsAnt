namespace LangtonAnt
{
	public enum Dir
	{
		None 	= -1,
		North 	= 0,
		East 	= 90,
		South 	= 180,
		West 	= 270
	}
	
	class Ant
	{
		public Ant(int x = 0, int y = 0, Dir d = Dir.North)
		{
			X = x;
			Y = y;
			Direction = d;
		}
		
		public int X { get; set; }
		public int Y { get; set; }
		public Dir Direction { get; protected set; }
		public Cell Cell { get { return new Cell(X, Y); } }
		
		public void TurnRight()
		{
			Direction = (Dir)((int)(Direction + 90) % 360);
		}
		
		public void TurnLeft()
		{
			int d = (int)Direction - 90;
			if(d < 0)
				d += 360;
			Direction = (Dir)d;
		}
		
		public static Dir GetDir(int i)
		{
			Dir d;
			
			if(i == 0)
				d = Dir.North;
			else if(i == 1)
				d = Dir.East;
			else if(i == 2)
				d = Dir.South;
			else if(i == 3)
				d = Dir.West;
			else
				d = Dir.None;
			
			return d;
		}
	}
}