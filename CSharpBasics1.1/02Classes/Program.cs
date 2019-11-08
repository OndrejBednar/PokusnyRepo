using System;

namespace Grading
{
    class person
    {
        public int Age;
        public double Weight = 66;
        public string Gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //person man1 = new person() { Age = 30, Weight = 92, Gender = "M", };

            //man1.Weight -= 12;

            person[] people = new person[2];
            int i = 1;
            ConsoleKeyInfo result;
            do
            {
                string gendertemp;
                string inputtemp;
                int agetemp;
                Console.Write("{0}. Člověk - věk: ", i);
                inputtemp = Console.ReadLine();
                int.TryParse(inputtemp, out agetemp);
                Console.Write("{0}. Člověk - pohlaví: ", i);
                gendertemp = Console.ReadLine();

                people[i - 1] = new person() { Age = agetemp, Gender = gendertemp };
                i += 1;

                Console.Write("Chceš vložit dalšího? [A]: ");
                result = Console.ReadKey();
                Console.WriteLine();

            } while (result.Key == ConsoleKey.A);

            Console.ReadKey();
        }
    }
}
