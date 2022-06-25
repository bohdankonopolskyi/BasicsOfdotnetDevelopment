using System;
namespace Lab4_StructuralPatterns
{
    /// <summary>
	/// Concrete decorator. Adds Fern leafs to existing bouquet
	/// </summary>
    public sealed class FernDecorator : Decorator
    {
        public FernDecorator(BouquetBase bouquet) : base(bouquet)
        {
        }

        public override string GetBouquetComposition()
        {
            return base.GetBouquetComposition() + $" with Fern ";
        }
    }
}

