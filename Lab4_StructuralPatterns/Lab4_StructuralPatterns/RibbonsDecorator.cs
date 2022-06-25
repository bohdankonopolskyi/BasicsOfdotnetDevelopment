using System;
namespace Lab4_StructuralPatterns
{
	/// <summary>
	/// Concrete decorator. Adds the ribbon with particular color to existing bouquet
	/// </summary>
	public class RibbonsDecorator : Decorator
	{
		public string Color { get; set; }
		public RibbonsDecorator(BouquetBase bouquet): base(bouquet)
        {
			
        }
		public override string GetBouquetComposition()
		{
			return base.GetBouquetComposition() + $" with {this.Color} ribbon ";
		}
	}
}

