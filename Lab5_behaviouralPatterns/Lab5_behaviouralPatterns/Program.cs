// todo: Розробити модель гри з фентезійними персонажами: орки, тролі, пегаси, ельфи, вампіри, гарпії і ін.
// деякі персонажі ходять, інші літають,
// і ходять і літають.
// Літати також може група персонажів за допомогою магії.

// Strategy pattern

using System;
namespace Lab5_behaviouralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // The artificial game  code  creates sprites,
            // picks a concrete strategy and passes it to the
            // sprite. 


            Console.WriteLine("Running Orc");
            Sprite orc1 = new Orc();
            orc1.SetMotionType(new Running());
            Console.WriteLine(orc1.Move());

            Console.WriteLine("Jumping orc");
            Sprite orc2 = new Orc();
            orc1.SetMotionType(new Jumping());
            Console.WriteLine(orc2.Move());

            Console.WriteLine("Flying elf");
            Sprite elf1 = new Elf();
            elf1.SetMotionType(new Flying());
            Console.WriteLine(elf1.Move());

            Console.WriteLine("Group with sprites");
            Sprite group = new Group();

            Group.AddToGroup(group, orc1);
            Group.AddToGroup(group, orc2);
            Group.AddToGroup(group, elf1);

            Console.WriteLine(group.Move());


            Console.WriteLine("Change group moving strategy");
            group.SetMotionType(new MagicFlying());
            Console.WriteLine(group.Move());

        }
    }
}

