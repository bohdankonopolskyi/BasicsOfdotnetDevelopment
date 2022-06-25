

// todo: Існує модель системи «Магазин квітів».
// Реалізувати задачу, що дозволяє додавати до букету новий атрибут (наприклад, стрічку з фірмовою назвою)

// Used Decorator pattern, because we have base components (flowers)
// which must be decorated with other components (ribbons, postcards, leafs)

using System;
namespace Lab4_StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rose bouquet decorated with Yellow Ribbon
            BouquetBase roses = new Rose() { Amount = 11, Price = 35};
            roses = new RibbonsDecorator(roses) { Color = "Yellow"};
            Console.WriteLine($"Bouquet of: {roses.GetBouquetComposition()}, Price: {roses.CalculatePrice()}");


            // Camomile bouquet decorated with Red Ribbon, then with Fern leafs
            BouquetBase camomiles = new Camomile() { Amount = 17, Price = 22 };
            camomiles = new RibbonsDecorator(camomiles) { Color = "Red" };
            camomiles = new FernDecorator(camomiles);
            Console.WriteLine($"Bouquet of: {camomiles.GetBouquetComposition()}, Price: {camomiles.CalculatePrice()}");

            // Chrysanthemum bouquet decorated with Bordo Ribbon, then with Fern leafs, them with PostCard
            BouquetBase chrysanthemums = new Chrysanthemum() { Amount = 7, Price = 18 };
            chrysanthemums = new RibbonsDecorator(chrysanthemums) { Color = "Bordo" };
            chrysanthemums = new FernDecorator(chrysanthemums);
            chrysanthemums = new PostcardDecorator(chrysanthemums, "Some postcard message!");
            Console.WriteLine($"Bouquet of: {chrysanthemums.GetBouquetComposition()}, Price: {chrysanthemums.CalculatePrice()}");

        }
    }
}

