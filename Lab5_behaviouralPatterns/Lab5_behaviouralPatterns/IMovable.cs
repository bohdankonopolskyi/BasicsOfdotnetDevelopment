using System;
namespace Lab5_behaviouralPatterns
{
	// The Strategy interface declares operations common to all supported
	// versions of move types (walk, run, jump, fly).
	//
	// The Context uses this interface to call the move type defined by Concrete
	// sprite
	public interface IMovable
	{
		string Move();
	}
}

