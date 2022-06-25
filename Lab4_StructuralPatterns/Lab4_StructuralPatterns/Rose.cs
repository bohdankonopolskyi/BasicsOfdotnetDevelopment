using System;
namespace Lab4_StructuralPatterns
{
	
	/// <summary>
	///  basic component Rose
	/// </summary>
	public class Rose : BouquetBase
	{
		public override string GetBouquetComposition()
		{
			return $"{this.Amount} of Rose ";
		}
	}
}

