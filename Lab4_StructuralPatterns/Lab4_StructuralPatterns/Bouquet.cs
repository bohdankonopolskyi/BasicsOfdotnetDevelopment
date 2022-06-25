using System;
namespace Lab4_StructuralPatterns
{

    //base class for common bouquet component
    //defines behaviour, which will be decorated
    public abstract class BouquetBase
    {
        // Amount of each component
        public int Amount { get; internal set; }

        // Cost of each component
        public decimal Price { get; internal set; }

        // Get composition of components (full decoration)
        public abstract string GetBouquetComposition();

        // Calculate price
        public virtual decimal CalculatePrice()
        {
            return Price * Amount;
        }

    }
}

