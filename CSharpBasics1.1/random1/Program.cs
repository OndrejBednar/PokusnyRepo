using System;

namespace random1
{

    class Program
    {
        static void Main(string[] args)
        {

            CertificateTable table = new CertificateTable();

            Display display1 = new Display(x: 10, y: 20, width: 30);
            Grade grade = new Grade() { Subject = "MAT", Score = 1 };
            display1.AddItem(new LabelItem("Hodnoceni", grade));
            display1.Refresh();

            /*ConsoleKeyInfo result;
            do
            {
                double grade;
                string temp;
                Console.Write("Předmět: ");
                temp = Console.ReadLine();
                Console.Write("Známka: ");
                double.TryParse(Console.ReadLine(), out grade);
                table.AddGrade(new Grade() { Subject = temp, Score = grade });
                Console.WriteLine("Chceš vložit dalšího? [A]: ");
                result = Console.ReadKey();
                Console.WriteLine();

            } while (result.Key == ConsoleKey.A || result.Key == ConsoleKey.Enter);

            Console.WriteLine(table);

            Console.ReadKey();*/
        }
    }
}
