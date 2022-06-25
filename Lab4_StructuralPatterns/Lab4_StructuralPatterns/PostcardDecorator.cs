using System;
namespace Lab4_StructuralPatterns
{
    /// <summary>
	/// Concrete decorator. Adds a Postcard message to existing bouquet
	/// </summary>
    public class PostcardDecorator : Decorator
    {
        private string message;
        public PostcardDecorator(BouquetBase bouquet, string PostcardText) : base(bouquet)
        {
            message = PostcardText;
        }

        public override string GetBouquetComposition()
        {
            return base.GetBouquetComposition() + $" with Postcard: {message} ";
        }


    }
}

