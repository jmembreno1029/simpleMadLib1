using System;

namespace Madlib1
{
    class Program
    {
        static void Main()
        {
            string creature;
            string luminous;
            string ghastly;
            string spectral;
            string countryman;
            string farrier;
            string farmer;
            string dreadful;
            string apparition;
            string hound;
            string story;

            Console.WriteLine("--------------------------");
            Console.WriteLine("          Madlib!");
            Console.WriteLine("--------------------------");

            Console.Write("Please enter a noun: ");
            creature = Console.ReadLine();
            Console.Write("Please enter an adjective: ");
            luminous = Console.ReadLine();
            Console.Write("Please enter an adjective: ");
            ghastly = Console.ReadLine();
            Console.Write("Please enter an adjective: ");
            spectral = Console.ReadLine();
            Console.Write("Please enter a noun: ");
            countryman = Console.ReadLine();
            Console.Write("Please enter an occupation: ");
            farrier = Console.ReadLine();
            Console.Write("Please enter an occupation: ");
            farmer = Console.ReadLine();
            Console.Write("Please enter an adjective: ");
            dreadful = Console.ReadLine();
            Console.Write("Please enter a noun: ");
            apparition = Console.ReadLine();
            Console.Write("Please enter a noun: ");
            hound = Console.ReadLine();

            story =
            "They all agreed that it was a huge " + creature + ", " + luminous + ", " + ghastly + 
            ", and " + spectral + ". I have cross-examined these men, one of them a hard-headed " + countryman + 
            ", one a " + farrier + ", and one a moorland " + farmer + ", who all tell the same story of this " + 
            dreadful + " " + apparition + ", exactly corresponding to the " + hound + " of the legend.";
            
            Console.WriteLine(story);
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
                      
        }
    }
}
