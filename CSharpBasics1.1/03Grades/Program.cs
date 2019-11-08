using System;
using DisplayHelper;

namespace random1
{

    class Program
    {
        static void Main(string[] args)
        {

            CertificateTable table = new CertificateTable();

            Display display1 = new Display(x: 13, y: 3, width: 30);
            Grade grade = new Grade() { Subject = "MAT", Score = 1 };



            ConsoleKeyInfo result;
            do
            {
                double grade1;
                string temp;
                Console.Write("Předmět: ");
                temp = Console.ReadLine();
                Console.Write("Známka: ");
                double.TryParse(Console.ReadLine(), out grade1);
                table.AddGrade(new Grade() { Subject = temp, Score = grade1 });
                display1.AddItem(new LabelItem("Hodnoceni", grade));
                display1.Refresh();
                Console.WriteLine("Chcete vložit další ? [A]");
                Console.SetCursorPosition(60,18);
                result = Console.ReadKey();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
            } while (result.Key == ConsoleKey.A || result.Key == ConsoleKey.Enter);
            Console.SetCursorPosition(0, 23);

            Console.WriteLine(table);

            Console.ReadKey();
        }
    }
}
