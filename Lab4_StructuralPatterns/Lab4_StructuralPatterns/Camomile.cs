using System;
namespace Lab4_StructuralPatterns
{
    /// <summary>
	/// Basic component Camomile
	/// </summary>
    public class Camomile : BouquetBase
    {
        public override string GetBouquetComposition()
        {
            return $"{this.Amount} of Camomile ";
        }
    }
}

