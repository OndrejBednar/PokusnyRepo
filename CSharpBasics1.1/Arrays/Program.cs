using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UnlimitedArray pole = new UnlimitedArray();
            ConsoleKeyInfo result;
            do
            {
                Console.WriteLine("Zadejte objekt");
                object obj = Console.ReadLine();
                Console.WriteLine("Zadejte pozici");
                uint.TryParse(Console.ReadLine(), out uint index);
                pole.Insert(obj, index);

                Console.WriteLine("Chcete vložit další ?");
                result = Console.ReadKey();
                Console.WriteLine("");
            } while (result.Key == ConsoleKey.A);

            
            Console.ReadKey();
        }
    }
}
