using System;
namespace Lab5_behaviouralPatterns
{
	public class Orc : Sprite
	{
		public Orc()
		{
           
            Speed = 15;
            CurrentPosition = 0;
        }

        public override bool IsGroup()
        {
            return false;
        }

        public override string Move()
        {
            CurrentPosition += Speed;
            return $"Orc {base._motion.Move()} with speed {this.Speed}, current X position {this.CurrentPosition}";
        }
    }
}

