using System;
namespace Lab5_behaviouralPatterns
{
	public class Elf : Sprite
	{
        
		public Elf()
		{
            Speed = 10;
            CurrentPosition = 0;
		}

        public override bool IsGroup()
        {
            return false;
        }

        public override string Move()
        {
            CurrentPosition += Speed;
            return $"Elf {base._motion.Move()} with speed {this.Speed}, current X position {this.CurrentPosition}";
        }
    }
}

