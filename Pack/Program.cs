using System;

namespace Pack
{
    class Program
    {
        static void Main(string[] args)
        {
            Meshok meshok = new(10, 20, 20);
            Arrow arrow = new();
            while (true)
            {
                Console.WriteLine($"Number of items: {meshok._currentCount} / {meshok._maxCount} Volume: {meshok._currentVolume} / {meshok._maxVolume} Weight: {meshok._currentWeight} / {meshok._maxWeight}");
                Console.WriteLine(arrow.ToString());
                Console.WriteLine("Input item number to add it to the meshok");
                Console.WriteLine("1 for arrow");
                Console.WriteLine("2 for bow");
                Console.WriteLine("3 for sword");
                Console.WriteLine("4 for ration");
                Console.WriteLine("5 for water");
                Console.WriteLine("6 for rope");

                int choice = Convert.ToInt32(Console.ReadLine());
                InventoryItem newItem = choice switch
                {
                    1 => new Arrow(),
                    2 => new Bow(),
                    3 => new Sword(),
                    4 => new Ration(),
                    5 => new Water(),
                    6 => new Rope(),
                    _ => new Zero()
                };
                
                if (!meshok.additem(newItem))
                {
                    Console.WriteLine("meshok is full");
                }
            }
        }
    }
}
