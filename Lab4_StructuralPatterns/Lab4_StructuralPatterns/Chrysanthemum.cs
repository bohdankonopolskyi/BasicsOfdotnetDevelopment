using System;
namespace Lab4_StructuralPatterns
{
	/// <summary>
	/// Basic component Chrysanthemum
	/// </summary>
	public class Chrysanthemum : BouquetBase
	{
		public override string GetBouquetComposition()
		{
			return $"{this.Amount} of Chrysanthemum ";
		}
	}
}

