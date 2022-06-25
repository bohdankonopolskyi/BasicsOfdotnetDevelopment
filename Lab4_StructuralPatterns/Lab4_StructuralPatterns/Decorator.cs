using System;
namespace Lab4_StructuralPatterns
{
    public abstract class Decorator : BouquetBase
    {
        /// <summary>
        /// Base class of decorator. Inherits the same class, as the common components
        /// The main porpouse is define intrface for wrapping all the particular decorators.
        /// </summary>

        /// <summary>
        /// The instance of decorator which should be wrapped
        /// </summary>
        protected readonly BouquetBase _bouquet;

        protected Decorator(BouquetBase bouquet)
        {
            _bouquet = bouquet;
        }

        public override string GetBouquetComposition()
        {
            return _bouquet.GetBouquetComposition();
        }

        public override decimal CalculatePrice()
        {
            return _bouquet.CalculatePrice() + Price;
        }

    }
}

